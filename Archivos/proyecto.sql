USE [master]
GO
/****** Object:  Database [Proyecto_Desarrollo]    Script Date: 12/15/2020 2:23:17 PM ******/
CREATE DATABASE [Proyecto_Desarrollo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto_Desarrollo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESSDEREK\MSSQL\DATA\Proyecto_Desarrollo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto_Desarrollo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESSDEREK\MSSQL\DATA\Proyecto_Desarrollo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proyecto_Desarrollo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto_Desarrollo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto_Desarrollo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto_Desarrollo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto_Desarrollo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proyecto_Desarrollo', N'ON'
GO
ALTER DATABASE [Proyecto_Desarrollo] SET QUERY_STORE = OFF
GO
USE [Proyecto_Desarrollo]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 12/15/2020 2:23:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idColaborador] [int] NOT NULL,
	[idFactura] [int] NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
	[fecha] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 12/15/2020 2:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTrabajo] [int] NOT NULL,
	[fechaPago] [date] NOT NULL,
	[totalBruto] [decimal](18, 5) NOT NULL,
	[impuesto] [decimal](18, 5) NOT NULL,
	[totalNeto] [decimal](18, 5) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 12/15/2020 2:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[detalle] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio_x_Colaborador]    Script Date: 12/15/2020 2:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio_x_Colaborador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idServicio] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajo]    Script Date: 12/15/2020 2:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idServicio] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[detalle] [nvarchar](50) NOT NULL,
	[costo] [decimal](18, 5) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/15/2020 2:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido1] [nvarchar](50) NOT NULL,
	[apellido2] [nvarchar](50) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
	[contrasenia] [nvarchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[latitud] [decimal](18, 10) NOT NULL,
	[longitud] [decimal](18, 10) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[fechaRegistro] [date] NOT NULL,
	[tipoUsuario] [nvarchar](50) NOT NULL,
	[estado] [int] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Proyecto_Desarrollo] SET  READ_WRITE 
GO
