USE [master]
GO
/****** Object:  Database [proyecto_desarrollo]    Script Date: 11/21/2020 1:01:23 PM ******/
CREATE DATABASE [proyecto_desarrollo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyecto_desarrollo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\proyecto_desarrollo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyecto_desarrollo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\proyecto_desarrollo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [proyecto_desarrollo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyecto_desarrollo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyecto_desarrollo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyecto_desarrollo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyecto_desarrollo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyecto_desarrollo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyecto_desarrollo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET RECOVERY FULL 
GO
ALTER DATABASE [proyecto_desarrollo] SET  MULTI_USER 
GO
ALTER DATABASE [proyecto_desarrollo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyecto_desarrollo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyecto_desarrollo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyecto_desarrollo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyecto_desarrollo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyecto_desarrollo', N'ON'
GO
ALTER DATABASE [proyecto_desarrollo] SET QUERY_STORE = OFF
GO
USE [proyecto_desarrollo]
GO
/****** Object:  Table [dbo].[cita]    Script Date: 11/21/2020 1:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cita](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_servicio] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[hora] [time](7) NOT NULL,
	[id_status] [int] NOT NULL,
	[id_colaborador] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[colaborador]    Script Date: 11/21/2020 1:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[colaborador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido1] [nvarchar](50) NOT NULL,
	[apellido2] [nvarchar](50) NOT NULL,
	[carnet] [int] NOT NULL,
	[placa] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturacion]    Script Date: 11/21/2020 1:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cita] [int] NOT NULL,
	[tipo_de_pago] [nvarchar](50) NOT NULL,
	[iva] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicio]    Script Date: 11/21/2020 1:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[costo] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status]    Script Date: 11/21/2020 1:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/21/2020 1:01:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido1] [nvarchar](50) NOT NULL,
	[apellido2] [nvarchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[telefono] [int] NOT NULL,
	[direccion] [nvarchar](max) NOT NULL,
	[latitud] [decimal](18, 0) NOT NULL,
	[longitud] [decimal](18, 0) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [proyecto_desarrollo] SET  READ_WRITE 
GO
