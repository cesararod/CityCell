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
    @cedula int,
    @telefono int,
    @celular int,
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
    @telefono [varchar](255),
    @celular float,
    @password int,
    @f_nac float,
    @f_ingres float,
    @email float,
    @genero float,    
    @rol int,
    @tipo_doc int

AS
    BEGIN
        INSERT INTO PRODUCTO(Nombre, Activo, Modelo, Descripcion, Precio, cantidad, Peso, Alto, Ancho, Largo, Marca_Id, Categoria_id, Fecha_Creacion)
        VALUES(@nombre,@activo,@modelo,@descripcion,@precio,@cantidad,@peso,@alto,@ancho,@largo,@fk_marca,@fk_categoria,@fecha_creacion);
    END;
GO

insert into Genero values('Masculino');
insert into Genero values('Femenino');

select * from rol

INSERT INTO USUARIO(Nombre,Apellido,Cedula,Telefono,Celular,Password,Fecha_Nacimineto,Fecha_Ingreso,Email,Genero_id,Rol_Id,Tipo_documento,Origen)
        VALUES('Cesar','Rodriguez','19195483','02124330234','04122300353','1234','23-02-1990 13:23:44','20-02-2017 13:23:44','carr235@gmail.com',1,1,'v','Pagina');

