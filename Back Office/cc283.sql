USE [master]
GO
/****** Object:  Database [CityCell]    Script Date: 03/28/2017 17:19:05 ******/
CREATE DATABASE [CityCell] ON  PRIMARY 
( NAME = N'CityCell', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CityCell.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CityCell_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CityCell_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CityCell] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CityCell].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CityCell] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CityCell] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CityCell] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CityCell] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CityCell] SET ARITHABORT OFF
GO
ALTER DATABASE [CityCell] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CityCell] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CityCell] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CityCell] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CityCell] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CityCell] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CityCell] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CityCell] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CityCell] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CityCell] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CityCell] SET  DISABLE_BROKER
GO
ALTER DATABASE [CityCell] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CityCell] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CityCell] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CityCell] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CityCell] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CityCell] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CityCell] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CityCell] SET  READ_WRITE
GO
ALTER DATABASE [CityCell] SET RECOVERY FULL
GO
ALTER DATABASE [CityCell] SET  MULTI_USER
GO
ALTER DATABASE [CityCell] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CityCell] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'CityCell', N'ON'
GO
USE [CityCell]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pago](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [float] NULL,
	[Numero_Referencia] [int] NULL,
	[Fecha_Registro] [date] NULL,
	[Banco] [varchar](255) NULL,
	[Tipo_pago] [varchar](100) NULL,
	[Descripcion] [varchar](255) NULL,
 CONSTRAINT [Pago_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Pago] ON
INSERT [dbo].[Pago] ([Id], [Monto], [Numero_Referencia], [Fecha_Registro], [Banco], [Tipo_pago], [Descripcion]) VALUES (1, 178.54, NULL, NULL, N'Mercantil', NULL, N'Pago de prueba')
SET IDENTITY_INSERT [dbo].[Pago] OFF
/****** Object:  Table [dbo].[Newsletter]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Newsletter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Correo] [varchar](1) NULL,
	[Activo] [int] NULL,
 CONSTRAINT [Newsletter_PK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NULL,
 CONSTRAINT [Rol_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON
INSERT [dbo].[Rol] ([Id], [Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([Id], [Nombre]) VALUES (2, N'Operador')
INSERT [dbo].[Rol] ([Id], [Nombre]) VALUES (3, N'Cliente')
SET IDENTITY_INSERT [dbo].[Rol] OFF
/****** Object:  Table [dbo].[Marca]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Imagen] [varchar](255) NULL,
	[Activo] [int] NULL,
	[Fecha_Creacion] [date] NULL,
 CONSTRAINT [Marca_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON
INSERT [dbo].[Marca] ([Id], [Nombre], [Imagen], [Activo], [Fecha_Creacion]) VALUES (1, N'HTC', N'ruta', 1, CAST(0x863C0B00 AS Date))
INSERT [dbo].[Marca] ([Id], [Nombre], [Imagen], [Activo], [Fecha_Creacion]) VALUES (2, N'Apple', N'ImgBrand\\apple.png', 1, CAST(0x8A3C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Marca] OFF
/****** Object:  Table [dbo].[Estatus]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](20) NULL,
 CONSTRAINT [Estatus_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Estatus] ON
INSERT [dbo].[Estatus] ([Id], [Estado]) VALUES (1, N'Pagado')
INSERT [dbo].[Estatus] ([Id], [Estado]) VALUES (2, N'Confirmado')
INSERT [dbo].[Estatus] ([Id], [Estado]) VALUES (3, N'Enviado')
INSERT [dbo].[Estatus] ([Id], [Estado]) VALUES (4, N'Fraude')
INSERT [dbo].[Estatus] ([Id], [Estado]) VALUES (5, N'Devuelto')
INSERT [dbo].[Estatus] ([Id], [Estado]) VALUES (6, N'Recibido')
SET IDENTITY_INSERT [dbo].[Estatus] OFF
/****** Object:  Table [dbo].[Estado]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [Estado_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Estado] ON
INSERT [dbo].[Estado] ([Id], [Nombre]) VALUES (1, N'Caracas')
SET IDENTITY_INSERT [dbo].[Estado] OFF
/****** Object:  Table [dbo].[Empresa_Envio]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa_Envio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Tracking_url] [varchar](255) NULL,
	[Tiempo_Envio] [int] NULL,
 CONSTRAINT [Empresa_Envio_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Empresa_Envio] ON
INSERT [dbo].[Empresa_Envio] ([Id], [Nombre], [Tracking_url], [Tiempo_Envio]) VALUES (1, N'TEALCA', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Empresa_Envio] OFF
/****** Object:  Table [dbo].[Genero]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Genero](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Sexo] [varchar](10) NULL,
 CONSTRAINT [Genero_PK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Genero] ON
INSERT [dbo].[Genero] ([id], [Sexo]) VALUES (1, N'Masculino')
INSERT [dbo].[Genero] ([id], [Sexo]) VALUES (2, N'Femenino')
SET IDENTITY_INSERT [dbo].[Genero] OFF
/****** Object:  Table [dbo].[Categoria]    Script Date: 03/28/2017 17:19:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Activo] [int] NULL,
	[Destacado] [int] NULL,
	[Fecha_Creacion] [date] NULL,
	[Categoria_id] [int] NULL,
 CONSTRAINT [Categoria_PK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON
INSERT [dbo].[Categoria] ([id], [Nombre], [Activo], [Destacado], [Fecha_Creacion], [Categoria_id]) VALUES (1, N'Celulares', 1, 1, CAST(0xE7370B00 AS Date), NULL)
INSERT [dbo].[Categoria] ([id], [Nombre], [Activo], [Destacado], [Fecha_Creacion], [Categoria_id]) VALUES (7, N'Smartphones', 1, 1, CAST(0x863C0B00 AS Date), NULL)
INSERT [dbo].[Categoria] ([id], [Nombre], [Activo], [Destacado], [Fecha_Creacion], [Categoria_id]) VALUES (8, N'Neveras', 0, 1, CAST(0x863C0B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Categoria] OFF
/****** Object:  StoredProcedure [dbo].[ConsultarCategorias]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarCategorias]

AS
	BEGIN
		SELECT id as id,Nombre as Nombre,Activo as Activo,Destacado as Destacado,Fecha_Creacion as Fecha_Creacion,Categoria_id as Categoria_id
		FROM Categoria;
	END
GO
/****** Object:  StoredProcedure [dbo].[AgregarMarca]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarMarca]
   
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
/****** Object:  StoredProcedure [dbo].[AgregarCategoria]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarCategoria]
   
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
/****** Object:  Table [dbo].[Garantia]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Garantia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Duracion] [varchar](15) NULL,
	[Condiciones] [varchar](255) NULL,
	[Marca_Id] [int] NOT NULL,
	[Activo] [int] NULL,
	[Categoria_id] [int] NOT NULL,
	[Fecha_Creacion] [date] NULL,
 CONSTRAINT [Garantia_PK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AgregarSubCategoria]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarSubCategoria]
   
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
/****** Object:  StoredProcedure [dbo].[ConsultarMarca]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarMarca]

AS
	BEGIN
		SELECT id as id,Nombre as Nombre,Activo as Activo,Imagen as Imagen,Fecha_Creacion as Fecha_Creacion
		FROM Marca;
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarMarca]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarMarca]
@id_marca int,
@activo int
AS
BEGIN
UPDATE Marca SET Activo = @activo   WHERE id = @id_marca
END;
GO
/****** Object:  StoredProcedure [dbo].[ModificarCategoria]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarCategoria]
@id_categoria int,
@activo int,
@destacado int
AS
BEGIN
UPDATE Categoria SET Activo = @activo , Destacado = @destacado  WHERE id = @id_categoria
END;
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[SKU] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Activo] [int] NULL,
	[Modelo] [varchar](50) NULL,
	[Descripcion] [varchar](255) NULL,
	[Precio] [float] NULL,
	[cantidad] [int] NULL,
	[Peso] [float] NULL,
	[Alto] [float] NULL,
	[Ancho] [float] NULL,
	[Largo] [float] NULL,
	[Marca_Id] [int] NOT NULL,
	[Categoria_id] [int] NOT NULL,
	[Fecha_Creacion] [date] NULL,
	[Fecha_Modificacion] [date] NULL,
 CONSTRAINT [Producto_PK] PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON
INSERT [dbo].[Producto] ([SKU], [Nombre], [Activo], [Modelo], [Descripcion], [Precio], [cantidad], [Peso], [Alto], [Ancho], [Largo], [Marca_Id], [Categoria_id], [Fecha_Creacion], [Fecha_Modificacion]) VALUES (1, N'ONE', 1, N'Plus', N'Descripcion de prueba', 78564, 85, 54, 454, 54, 45, 1, 1, CAST(0x8D3C0B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Producto] OFF
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Nombre] [varchar](20) NULL,
	[Apellido] [varchar](50) NULL,
	[Cedula] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Password] [varchar](20) NULL,
	[Fecha_Nacimineto] [date] NULL,
	[Fecha_Ingreso] [date] NULL,
	[Email] [varchar](255) NULL,
	[Genero_id] [int] NOT NULL,
	[Rol_Id] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_documento] [varchar](1) NULL,
	[Origen] [varchar](20) NULL,
	[Validacion_DC] [int] NULL,
	[Valido_DC] [int] NULL,
 CONSTRAINT [Usuario_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([Nombre], [Apellido], [Cedula], [Telefono], [Celular], [Password], [Fecha_Nacimineto], [Fecha_Ingreso], [Email], [Genero_id], [Rol_Id], [Id], [Tipo_documento], [Origen], [Validacion_DC], [Valido_DC]) VALUES (N'Cesar', N'Rodriguez', N'19195483', N'04141203235', N'04122300353', N'123', CAST(0xF8150B00 AS Date), CAST(0x903C0B00 AS Date), N'crodriguez@citycellgsm.com', 1, 1, 1, N'1', N'', 0, 0)
INSERT [dbo].[Usuario] ([Nombre], [Apellido], [Cedula], [Telefono], [Celular], [Password], [Fecha_Nacimineto], [Fecha_Ingreso], [Email], [Genero_id], [Rol_Id], [Id], [Tipo_documento], [Origen], [Validacion_DC], [Valido_DC]) VALUES (N'Andreina', N'Corro', N'26465730', N'02124330234', N'04122300353', N'123', CAST(0x983C0B00 AS Date), CAST(0x983C0B00 AS Date), N'crodriguez@citycellgsm.com', 2, 1, 7, N'1', N'n/a', 0, 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  StoredProcedure [dbo].[ModificarProducto]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarProducto]
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
GO
/****** Object:  Table [dbo].[Promocion]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promocion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Producto_id] [int] NOT NULL,
	[Fecha_Inicio] [date] NULL,
	[Fecha_Fin] [date] NULL,
	[Activo] [int] NULL,
	[Fecha_Creacion] [date] NULL,
	[Precio] [float] NULL,
 CONSTRAINT [Promocion_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Promocion] ON
INSERT [dbo].[Promocion] ([Id], [Producto_id], [Fecha_Inicio], [Fecha_Fin], [Activo], [Fecha_Creacion], [Precio]) VALUES (1, 1, CAST(0x8B3C0B00 AS Date), CAST(0x8B3C0B00 AS Date), 1, CAST(0x8D3C0B00 AS Date), 159)
INSERT [dbo].[Promocion] ([Id], [Producto_id], [Fecha_Inicio], [Fecha_Fin], [Activo], [Fecha_Creacion], [Precio]) VALUES (4, 1, CAST(0x933C0B00 AS Date), CAST(0xA23C0B00 AS Date), 1, CAST(0x913C0B00 AS Date), 435)
SET IDENTITY_INSERT [dbo].[Promocion] OFF
/****** Object:  Table [dbo].[Imagen]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Imagen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Producto_id] [int] NOT NULL,
	[Ruta] [varchar](255) NULL,
 CONSTRAINT [Imagen_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ConsultarProductos]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarProductos]
AS
    BEGIN
        select Producto.SKU as SKU,Producto.Nombre as Nombre,Producto.Modelo as Modelo,Producto.cantidad as cantidad, Producto.Activo As Activo,
Producto.Precio as Precio, Producto.Descripcion as Descripcion,  Producto.Peso as Peso, Producto.Alto as Alto, Producto.Ancho as Ancho,
Producto.Largo as Largo, Producto.Fecha_Creacion, Producto.Fecha_Modificacion, Producto.Marca_Id, Producto.Categoria_id
 from producto
    END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaUsuario]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaUsuario]

AS
    BEGIN
       select Id as UsuId, Nombre as Nombre, Apellido as Apellido, Cedula as Cedula, 
              Telefono as Tele, Celular as celular, Fecha_Ingreso as Fecha_Creacion, Email as Email, 
              Fecha_Nacimineto as FechaNac from usuario 
    END
GO
/****** Object:  StoredProcedure [dbo].[ModificarGarantia]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarGarantia]
    @id_garantia int,
    @condiciones [varchar](255)

AS
    BEGIN
       update Garantia set Condiciones = @condiciones
       where Garantia.id = @id_garantia
    END;
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarUsuario]
   
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
/****** Object:  Table [dbo].[Direccion]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Direccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ciudad] [varchar](255) NULL,
	[Municipio] [varchar](255) NULL,
	[Parroquia] [varchar](255) NULL,
	[Zona] [varchar](255) NULL,
	[Calle] [varchar](255) NULL,
	[Edificio_Casa] [varchar](255) NULL,
	[Apartamento] [varchar](255) NULL,
	[Estado_Id] [int] NOT NULL,
	[Usuario_Id] [int] NOT NULL,
 CONSTRAINT [Direccion_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Direccion] ON
INSERT [dbo].[Direccion] ([Id], [Ciudad], [Municipio], [Parroquia], [Zona], [Calle], [Edificio_Casa], [Apartamento], [Estado_Id], [Usuario_Id]) VALUES (1, N'caracas', N'libertador', NULL, NULL, NULL, NULL, NULL, 1, 7)
SET IDENTITY_INSERT [dbo].[Direccion] OFF
/****** Object:  StoredProcedure [dbo].[ConsultarGarantia]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarGarantia]
AS
Begin
select Garantia.id as id,Marca.Nombre as Marca,Categoria.Nombre AS Categoria, Garantia.Condiciones as Condiciones
from Garantia,Marca,Categoria
where
Garantia.Marca_Id = Marca.Id and
Garantia.Categoria_id = Categoria.id
End
GO
/****** Object:  StoredProcedure [dbo].[AgregarUsuario]    Script Date: 03/28/2017 17:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarUsuario]
   
    @nombre [varchar](20),
    @apellido [varchar](50),
    @cedula [varchar](50),
    @telefono [varchar](50),
    @celular [varchar](50),
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
/****** Object:  StoredProcedure [dbo].[AgregarProducto]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarProducto]
   
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
/****** Object:  StoredProcedure [dbo].[AgregarGarantia]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarGarantia]
   
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
/****** Object:  Table [dbo].[Compra_Producto]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compra_Producto](
	[Fecha] [date] NULL,
	[Producto_id] [int] NOT NULL,
	[Compra_Pedido] [varchar](255) NOT NULL,
	[Precio] [float] NULL,
 CONSTRAINT [Compra_Producto_PK] PRIMARY KEY CLUSTERED 
(
	[Producto_id] ASC,
	[Compra_Pedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Compra_Producto] ([Fecha], [Producto_id], [Compra_Pedido], [Precio]) VALUES (CAST(0x983C0B00 AS Date), 1, N'3', 199.8416)
/****** Object:  Table [dbo].[Compra]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pedido] [varchar](255) NOT NULL,
	[Sub-Total] [float] NULL,
	[IVA] [float] NULL,
	[Estatus_Id] [int] NOT NULL,
	[Usuario_Id] [int] NOT NULL,
	[Precio_Envio] [float] NULL,
	[Numero_Pedido] [varchar](50) NULL,
	[Direccion_Id] [int] NOT NULL,
	[Direccion_Id1] [int] NOT NULL,
	[Pago_Id] [int] NOT NULL,
	[Empresa_Envio_Id] [int] NOT NULL,
 CONSTRAINT [Compra_PK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON
INSERT [dbo].[Compra] ([Id], [Pedido], [Sub-Total], [IVA], [Estatus_Id], [Usuario_Id], [Precio_Envio], [Numero_Pedido], [Direccion_Id], [Direccion_Id1], [Pago_Id], [Empresa_Envio_Id]) VALUES (3, N'123', 178.43, 12, 4, 7, 100, N'track1234', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Compra] OFF
/****** Object:  StoredProcedure [dbo].[AgregarPromocion]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarPromocion]
   
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
/****** Object:  StoredProcedure [dbo].[ModificarPromocion]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarPromocion]
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
GO
/****** Object:  StoredProcedure [dbo].[ConsultarPromociones]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarPromociones]
AS
    BEGIN
        select Promocion.Id as Promo_id,Promocion.Producto_id as Producto_id, Promocion.Fecha_Inicio as Fecha_Inicio,
         Promocion.Fecha_Fin as Fecha_Fin, Promocion.Activo as Activo, Promocion.Fecha_Creacion as Fecha_Creacion,
         Promocion.Precio as Precio
          from Promocion
    END
GO
/****** Object:  StoredProcedure [dbo].[ModificarVenta]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarVenta]
@idVenta int,
@estatus int
AS
BEGIN
UPDATE Compra SET Estatus_Id = @estatus  WHERE Id = @idVenta
END;
GO
/****** Object:  StoredProcedure [dbo].[ConsultaVenta]    Script Date: 03/28/2017 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaVenta]

AS
    BEGIN
select Compra.Id as idventa, Compra.pedido as numpedido, Compra."Sub-Total" as subtotal,Compra.IVA as iva, Estatus.Estado as estatus, 
Usuario.Nombre as nombreusu,Usuario.Apellido as apeusu,Usuario.Email as correo,Compra.Precio_Envio as precioenv,Compra.Numero_Pedido as track,Direccion.Ciudad as Dirfacturacion,
Direccion.Ciudad as DirEnvio,Compra.Pago_Id numpago,Empresa_Envio.Nombre as operador,Marca.Nombre as Marca,producto.Nombre ,Producto.Modelo, compra_producto.Fecha
from Compra, Usuario, Estatus, Direccion, Pago, Empresa_Envio, compra_producto, Producto, Marca
where Usuario.Id = Compra.Usuario_Id 
and Estatus.Id = Compra.Estatus_Id
and Direccion.Id = Compra.Direccion_Id
and Direccion.Id = Compra.Direccion_Id1
and Pago.Id = Compra.Pago_Id
and Empresa_Envio.Id = Compra.Empresa_Envio_Id
and Direccion.Usuario_Id = Usuario.Id
and compra_producto.Compra_Pedido =  Compra.Id
and compra_producto.Producto_id = Producto.sku
and producto.Marca_Id = Marca.Id

    END
GO
/****** Object:  ForeignKey [Categoria_Categoria_FK]    Script Date: 03/28/2017 17:19:06 ******/
ALTER TABLE [dbo].[Categoria]  WITH CHECK ADD  CONSTRAINT [Categoria_Categoria_FK] FOREIGN KEY([Categoria_id])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Categoria] CHECK CONSTRAINT [Categoria_Categoria_FK]
GO
/****** Object:  ForeignKey [Garantia_Categoria_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Garantia]  WITH CHECK ADD  CONSTRAINT [Garantia_Categoria_FK] FOREIGN KEY([Categoria_id])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Garantia] CHECK CONSTRAINT [Garantia_Categoria_FK]
GO
/****** Object:  ForeignKey [Garantia_Marca_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Garantia]  WITH CHECK ADD  CONSTRAINT [Garantia_Marca_FK] FOREIGN KEY([Marca_Id])
REFERENCES [dbo].[Marca] ([Id])
GO
ALTER TABLE [dbo].[Garantia] CHECK CONSTRAINT [Garantia_Marca_FK]
GO
/****** Object:  ForeignKey [Producto_Categoria_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [Producto_Categoria_FK] FOREIGN KEY([Categoria_id])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [Producto_Categoria_FK]
GO
/****** Object:  ForeignKey [Producto_Marca_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [Producto_Marca_FK] FOREIGN KEY([Marca_Id])
REFERENCES [dbo].[Marca] ([Id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [Producto_Marca_FK]
GO
/****** Object:  ForeignKey [Usuario_Genero_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Usuario_Genero_FK] FOREIGN KEY([Genero_id])
REFERENCES [dbo].[Genero] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Usuario_Genero_FK]
GO
/****** Object:  ForeignKey [Usuario_Rol_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Usuario_Rol_FK] FOREIGN KEY([Rol_Id])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Usuario_Rol_FK]
GO
/****** Object:  ForeignKey [Promocion_Producto_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Promocion]  WITH CHECK ADD  CONSTRAINT [Promocion_Producto_FK] FOREIGN KEY([Producto_id])
REFERENCES [dbo].[Producto] ([SKU])
GO
ALTER TABLE [dbo].[Promocion] CHECK CONSTRAINT [Promocion_Producto_FK]
GO
/****** Object:  ForeignKey [Imagen_Producto_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Imagen]  WITH CHECK ADD  CONSTRAINT [Imagen_Producto_FK] FOREIGN KEY([Producto_id])
REFERENCES [dbo].[Producto] ([SKU])
GO
ALTER TABLE [dbo].[Imagen] CHECK CONSTRAINT [Imagen_Producto_FK]
GO
/****** Object:  ForeignKey [Direccion_Estado_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [Direccion_Estado_FK] FOREIGN KEY([Estado_Id])
REFERENCES [dbo].[Estado] ([Id])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [Direccion_Estado_FK]
GO
/****** Object:  ForeignKey [Direccion_Usuario_FK]    Script Date: 03/28/2017 17:19:07 ******/
ALTER TABLE [dbo].[Direccion]  WITH CHECK ADD  CONSTRAINT [Direccion_Usuario_FK] FOREIGN KEY([Usuario_Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Direccion] CHECK CONSTRAINT [Direccion_Usuario_FK]
GO
/****** Object:  ForeignKey [Compra_Producto_Producto_FK]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra_Producto]  WITH CHECK ADD  CONSTRAINT [Compra_Producto_Producto_FK] FOREIGN KEY([Producto_id])
REFERENCES [dbo].[Producto] ([SKU])
GO
ALTER TABLE [dbo].[Compra_Producto] CHECK CONSTRAINT [Compra_Producto_Producto_FK]
GO
/****** Object:  ForeignKey [Compra_Direccion_FK]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [Compra_Direccion_FK] FOREIGN KEY([Direccion_Id])
REFERENCES [dbo].[Direccion] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [Compra_Direccion_FK]
GO
/****** Object:  ForeignKey [Compra_Direccion_FKv1]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [Compra_Direccion_FKv1] FOREIGN KEY([Direccion_Id1])
REFERENCES [dbo].[Direccion] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [Compra_Direccion_FKv1]
GO
/****** Object:  ForeignKey [Compra_Empresa_Envio_FK]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [Compra_Empresa_Envio_FK] FOREIGN KEY([Empresa_Envio_Id])
REFERENCES [dbo].[Empresa_Envio] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [Compra_Empresa_Envio_FK]
GO
/****** Object:  ForeignKey [Compra_Estatus_FK]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [Compra_Estatus_FK] FOREIGN KEY([Estatus_Id])
REFERENCES [dbo].[Estatus] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [Compra_Estatus_FK]
GO
/****** Object:  ForeignKey [Compra_Pago_FK]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [Compra_Pago_FK] FOREIGN KEY([Pago_Id])
REFERENCES [dbo].[Pago] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [Compra_Pago_FK]
GO
/****** Object:  ForeignKey [Compra_Usuario_FK]    Script Date: 03/28/2017 17:19:08 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [Compra_Usuario_FK] FOREIGN KEY([Usuario_Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [Compra_Usuario_FK]
GO
