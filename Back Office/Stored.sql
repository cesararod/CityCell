CREATE PROCEDURE ConsultarCategoria

AS
    BEGIN
        SELECT id as id,Nombre as Nombre,Activo as Activo,Destacado as Destacado,Fecha_Creacion as Fecha_Creacion,Categoria_id as Categoria_id
        FROM Categoria;
    END
GO

CREATE PROCEDURE ConsultarMarca

AS
    BEGIN
        SELECT id as id,Nombre as Nombre,Activo as Activo,Imagen as Imagen,Fecha_Creacion as Fecha_Creacion
        FROM Marca;
    END
GO

CREATE PROCEDURE AgregarCategoria
   
    @nombre [varchar](50),
    @destacado int,
    @activo int,
    @fecha_creacion date

AS
    BEGIN
        INSERT INTO CATEGORIA(Nombre, Activo, Destacado, Fecha_Creacion)
        VALUES(@nombre,@activo,@destacado,@fecha_creacion);
    END;
GO

CREATE PROCEDURE AgregarSubCategoria
   
    @nombre [varchar](50),
    @activo int,
    @destacado int,
    @fecha_creacion date,
    @fk_categoria int

AS
    BEGIN
        INSERT INTO CATEGORIA(Nombre, Activo, Destacado, Fecha_Creacion, Categoria_id)
        VALUES(@nombre,@activo,@destacado,@fecha_creacion,@fk_categoria);
    END;
GO

CREATE PROCEDURE AgregarMarca
   
    @nombre [varchar](50),
    @imagen [varchar](255),
    @activo int,
    @fecha_creacion date

AS
    BEGIN
        INSERT INTO MARCA(Nombre, Imagen, Activo, Fecha_Creacion)
        VALUES(@nombre,@imagen,@activo,@fecha_creacion);
    END;
GO

CREATE PROCEDURE AgregarProducto
   
    @nombre [varchar](50),
    @activo int,
    @modelo [varchar](50),
    @descripcion [varchar](255),
    @precio float,
    @cantidad int,
    @peso float,
    @alto float,
    @ancho float,
    @largo float,    
    @fk_marca int,
    @fk_categoria int,
    @fecha_creacion date

AS
    BEGIN
        INSERT INTO PRODUCTO(Nombre, Activo, Modelo, Descripcion, Precio, cantidad, Peso, Alto, Ancho, Largo, Marca_Id, Categoria_id, Fecha_Creacion)
        VALUES(@nombre,@activo,@modelo,@descripcion,@precio,@cantidad,@peso,@alto,@ancho,@largo,@fk_marca,@fk_categoria,@fecha_creacion);
    END;
GO

CREATE PROCEDURE AgregarPromocion
        
    @fk_producto int,
    @fecha_inicio date,
    @fecha_fin date,
    @activo int,
    @fecha_creacion date,
    @precio float

AS
    BEGIN
        INSERT INTO PROMOCION(Producto_id,Fecha_Inicio,Fecha_Fin,Activo,Fecha_Creacion,Precio)
        VALUES(@fk_producto,@fecha_inicio,@fecha_fin,@activo,@fecha_creacion,@precio);
    END;
GO

CREATE PROCEDURE AgregarGarantia
   
    @duracion [varchar](15),
    @condiciones [varchar](255),
    @fk_marca int,
    @activo int,
    @fk_categoria int,
    @fecha_creacion date

AS
    BEGIN
        INSERT INTO GARANTIA(Duracion,Condiciones,Marca_Id,Activo,Categoria_id,Fecha_Creacion)
        VALUES(@duracion,@condiciones,@fk_marca,@activo,@fk_categoria,@fecha_creacion);
    END;
GO

CREATE PROCEDURE AgregarUsuario
   
    @nombre [varchar](20),
    @apellido [varchar](50),
    @cedula [varchar](20),
    @telefono [varchar](20),
    @celular [varchar](20),
    @password [varchar](20),
    @fecha_nac date,
    @fecha_ingreso date,
    @email [varchar](255),
    @fk_genero int,
    @fk_rol int,
    @tipo_doc [varchar](1),
    @origen [varchar](20),
    @validacion_dc int,
    @valido_dc int    

AS
    BEGIN
        INSERT INTO USUARIO(Nombre,Apellido,Cedula,Telefono,Celular,Password,Fecha_Nacimineto,Fecha_Ingreso,Email,Genero_id,Rol_Id,Tipo_documento,Origen,Validacion_DC,Valido_DC)
        VALUES(@nombre,@apellido,@cedula,@telefono,@celular,@password,@fecha_nac,@fecha_ingreso,@email,@fk_genero,@fk_rol,@tipo_doc,@origen,@validacion_dc,@valido_dc);
    END;
GO

CREATE PROCEDURE AgregarUsuario
   
    @nombre [varchar](50),
    @apellido [varchar](50),
    @cedula [varchar](50),
    @telefono [varchar](50),
    @celular [varchar](50),
    @password [varchar](20),
    @f_nac date,
    @f_ingres date,
    @email [varchar](255),
    @genero int,    
    @rol int,
    @tipo_doc int

AS
    BEGIN
        INSERT INTO PRODUCTO(Nombre, Activo, Modelo, Descripcion, Precio, cantidad, Peso, Alto, Ancho, Largo, Marca_Id, Categoria_id, Fecha_Creacion)
        VALUES(@nombre,@activo,@modelo,@descripcion,@precio,@cantidad,@peso,@alto,@ancho,@largo,@fk_marca,@fk_categoria,@fecha_creacion);
    END;
GO

CREATE PROCEDURE ConsultarProductos
AS
    BEGIN
        select Producto.SKU as SKU,Producto.Nombre as Nombre,Producto.Modelo as Modelo,Producto.cantidad as cantidad, Producto.Activo As Activo,
Producto.Precio as Precio, Producto.Descripcion as Descripcion,  Producto.Peso as Peso, Producto.Alto as Alto, Producto.Ancho as Ancho,
Producto.Largo as Largo, Producto.Fecha_Creacion, Producto.Fecha_Modificacion, Producto.Marca_Id, Producto.Categoria_id
 from producto
    END
GO

CREATE PROCEDURE ConsultarPromociones
AS
    BEGIN
        select Promocion.Id as Promo_id,Promocion.Producto_id as Producto_id, Promocion.Fecha_Inicio as Fecha_Inicio,
         Promocion.Fecha_Fin as Fecha_Fin, Promocion.Activo as Activo, Promocion.Fecha_Creacion as Fecha_Creacion,
         Promocion.Precio as Precio
          from Promocion
    END
GO

CREATE PROCEDURE AgregarPromocion
   
    @precio float,
    @producto int,
    @activo int,
    @fecha_inicio date,
    @fecha_fin date,
    @fecha_creacion date

AS
    BEGIN
        INSERT INTO Promocion(Producto_id,Fecha_Inicio,Fecha_Fin,Activo,Fecha_Creacion,Precio)
        VALUES(@producto,@fecha_inicio,@fecha_fin,@activo,@fecha_creacion,@precio);
    END;
GO


CREATE PROCEDURE ModificarPromocion
@id_promocion int,
@activo int,
@precio float,
@fecha_inicio date,
@fecha_fin date
AS
BEGIN
UPDATE Promocion SET Activo = @activo, Precio = @precio, Fecha_Inicio = @fecha_inicio , Fecha_Fin = @fecha_fin
  WHERE id = @id_promocion
END;


CREATE PROCEDURE ModificarProducto
@id_producto int,
@activo int,
@nombre varchar(50),
@modelo varchar(50),
@descripcion varchar(255),
@precio float,
@cantidad int
AS
BEGIN
UPDATE Producto SET Activo = @activo, Nombre= @nombre, Modelo = @modelo, Descripcion= @descripcion,
Precio = @precio, cantidad = @cantidad   WHERE SKU = @id_producto
END;

CREATE PROCEDURE ConsultaUsuario

AS
    BEGIN
       select Id as UsuId, Nombre as Nombre, Apellido as Apellido, Cedula as Cedula, 
              Telefono as Tele, Celular as celular, Fecha_Ingreso as Fecha_Creacion, Email as Email, 
              Fecha_Nacimineto as FechaNac from usuario 
    END
GO

CREATE PROCEDURE ModificarUsuario
   
    @telefono [varchar](50),
    @celular [varchar](50),
    @password [varchar](20),
    @idUsu int,
    @email [varchar](255)  

AS
    BEGIN
UPDATE Usuario SET Telefono = @telefono, Celular= @celular, Password = @password, Email= @email
 WHERE Id = @idUsu
END;
GO

insert into Genero values('Masculino');
insert into Genero values('Femenino');

select * from rol

insert into Estado (Nombre) values ('Caracas')
insert into dbo.Empresa_Envio (NOMBRE) values ('TEALCA')
insert into Estatus values ('Recibido')   
insert into Pago (Monto, Descripcion, Banco) values (178.54,'Pago de prueba', 'Mercantil')
ALTER TABLE compra DROP COLUMN Usuario_Cedula;
insert into dbo.Compra (Pedido, [Sub-Total],IVA,Precio_Envio,Numero_Pedido,Estatus_Id,
                        Usuario_Id,Direccion_Id,Direccion_Id1,Pago_Id,Empresa_Envio_Id) values 
                        (123,178.43,12,100,'track1234',1,7,1,1,1,1);
 
SET IDENTITY_INSERT [dbo].direccion ON                        
insert into direccion (Id,Ciudad,Municipio,Estado_Id,Usuario_Id)values (1,'caracas','libertador',1,7);
insert into Compra_Producto(Fecha,Precio,Producto_id,Compra_Pedido) values (CURRENT_TIMESTAMP, 199.8416,1,1);    
INSERT INTO USUARIO(Nombre,Apellido,Cedula,Telefono,Celular,Password,Fecha_Nacimineto,Fecha_Ingreso,Email,Genero_id,Rol_Id,Tipo_documento,Origen)
        VALUES('Cesar','Rodriguez','19195483','02124330234','04122300353','1234','23-02-1990 13:23:44','20-02-2017 13:23:44','carr235@gmail.com',1,1,'v','Pagina');

