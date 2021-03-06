USE [master]
GO
/****** Object:  Database [Bancolombia]    Script Date: 30/05/2018 04:56:37 p.m. ******/
CREATE DATABASE [Bancolombia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bancolombia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MYSQL\MSSQL\DATA\Bancolombia.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bancolombia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MYSQL\MSSQL\DATA\Bancolombia_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Bancolombia] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bancolombia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bancolombia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bancolombia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bancolombia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bancolombia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bancolombia] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bancolombia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bancolombia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bancolombia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bancolombia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bancolombia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bancolombia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bancolombia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bancolombia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bancolombia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bancolombia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bancolombia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bancolombia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bancolombia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bancolombia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bancolombia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bancolombia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bancolombia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bancolombia] SET RECOVERY FULL 
GO
ALTER DATABASE [Bancolombia] SET  MULTI_USER 
GO
ALTER DATABASE [Bancolombia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bancolombia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bancolombia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bancolombia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Bancolombia] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Bancolombia]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[ingresos] [int] NOT NULL,
	[egresos] [int] NOT NULL,
	[pasivos] [int] NOT NULL,
	[scoring] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Credito]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Credito](
	[id_credito] [int] IDENTITY(1,1) NOT NULL,
	[plazo] [int] NOT NULL,
	[monto] [int] NOT NULL,
	[total_interes] [int] NOT NULL,
	[anualidad] [int] NOT NULL,
	[tnm] [float] NOT NULL,
	[tea] [float] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[total_monto_intereses] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Credito] PRIMARY KEY CLUSTERED 
(
	[id_credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[consultarCliente]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consultarCliente]

	@Cedula varchar(50)
	
As
SELECT id_cliente,cedula,nombre,direccion,ingresos,egresos,pasivos,scoring FROM Cliente
WHERE cedula = @Cedula

GO
/****** Object:  StoredProcedure [dbo].[consultarProductosPorCliente]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consultarProductosPorCliente]
	@Cedula varchar(50)
as
	select cre.id_credito, cre.nombre, cre.monto, cre.plazo, cre.tea , cre.tnm, cre.total_interes, cre.total_monto_intereses
	from Cliente as cli
		inner join Credito as cre
			on cli.id_cliente = cre.id_cliente
	where cli.cedula = @Cedula

GO
/****** Object:  StoredProcedure [dbo].[crearCredito]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[crearCredito]
	@Plazo int,
	@Monto int,
	@TotalInteres int,
	@Anualidad int,
	@Tnm float,
	@Tea float,
	@IdCliente int,
	@TotalMontoIntereses int

As 
	INSERT INTO Credito(plazo,monto,total_interes,anualidad,tnm,tea,id_cliente, total_monto_intereses)
	VALUES (@Plazo,@Monto,@TotalInteres,@Anualidad,@Tnm,@Tea,@IdCliente, @TotalMontoIntereses); 
	

GO
/****** Object:  StoredProcedure [dbo].[eliminarCliente]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarCliente]
	@IdCliente int
As
DELETE FROM Cliente
WHERE id_cliente = @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[insertarCliente]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarCliente]
	@Cedula varchar(50),
	@Nombre varchar(50),
	@Direccion varchar(50),
	@Ingresos int,
	@Egresos int,
	@Pasivos int,
	@Scoring int

As 
	INSERT INTO Cliente (cedula,nombre,direccion,ingresos,egresos,pasivos,scoring)
	VALUES (@Cedula,@Nombre,@Direccion,@Ingresos,@Egresos,@Pasivos,@Scoring); 
	

GO
/****** Object:  StoredProcedure [dbo].[listarClientes]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listarClientes]
As
SELECT id_cliente,cedula,nombre,direccion,ingresos,egresos,pasivos,scoring FROM Cliente

GO
/****** Object:  StoredProcedure [dbo].[modificarCliente]    Script Date: 30/05/2018 04:56:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[modificarCliente]
	@IdCliente int,
	@Cedula varchar(50),
	@Nombre varchar(50),
	@Direccion varchar(50),
	@Ingresos int,
	@Egresos int,
	@Pasivos int,
	@Scoring int

As 
	UPDATE Cliente
	SET cedula = @Cedula,nombre = @Nombre,direccion = @Direccion,ingresos = @Ingresos,egresos= @Egresos,pasivos = @Pasivos,scoring = @Scoring
	WHERE id_cliente = @IdCliente
	

GO
USE [master]
GO
ALTER DATABASE [Bancolombia] SET  READ_WRITE 
GO
