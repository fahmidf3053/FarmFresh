USE [master]
GO
/****** Object:  Database [FarmFreshDB]    Script Date: 3/8/2023 1:55:13 AM ******/
CREATE DATABASE [FarmFreshDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FarmFresh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER03\MSSQL\DATA\FarmFresh.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FarmFresh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER03\MSSQL\DATA\FarmFresh_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FarmFreshDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FarmFreshDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FarmFreshDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FarmFreshDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FarmFreshDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FarmFreshDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FarmFreshDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FarmFreshDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FarmFreshDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FarmFreshDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FarmFreshDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FarmFreshDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FarmFreshDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FarmFreshDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FarmFreshDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FarmFreshDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FarmFreshDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FarmFreshDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FarmFreshDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FarmFreshDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FarmFreshDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FarmFreshDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FarmFreshDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FarmFreshDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FarmFreshDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FarmFreshDB] SET  MULTI_USER 
GO
ALTER DATABASE [FarmFreshDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FarmFreshDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FarmFreshDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FarmFreshDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FarmFreshDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FarmFreshDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FarmFreshDB', N'ON'
GO
ALTER DATABASE [FarmFreshDB] SET QUERY_STORE = OFF
GO
USE [FarmFreshDB]
GO
/****** Object:  User [FarmFresh]    Script Date: 3/8/2023 1:55:14 AM ******/
CREATE USER [FarmFresh] FOR LOGIN [FarmFresh] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [FarmFresh]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/8/2023 1:55:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[About] [varchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Image] [varchar](50) NOT NULL,
	[Origin] [varchar](50) NULL,
	[EntityState] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [Name], [About], [Price], [Type], [Image], [Origin], [EntityState]) VALUES (1, N'Ripe Blue Grape', N'From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes. Thanks to this amazing journey through the Chambotte mountains, it acquires its unique fresgqualities. With our passion for preserving this natural heritage, we are proud to offer you this moment of purity in your busy lives.', CAST(200.00 AS Decimal(18, 2)), N'Packet', N'grape.png', N'France', 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [About], [Price], [Type], [Image], [Origin], [EntityState]) VALUES (2, N'Salmon', N'From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes. Thanks to this amazing journey through the Chambotte mountains, it acquires its unique fresgqualities. With our passion for preserving this natural heritage, we are proud to offer you this moment of purity in your busy lives.', CAST(300.00 AS Decimal(18, 2)), N'Packet', N'salmon.png', N'USA', 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [About], [Price], [Type], [Image], [Origin], [EntityState]) VALUES (3, N'Small Grape', N'From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes. Thanks to this amazing journey through the Chambotte mountains, it acquires its unique fresgqualities. With our passion for preserving this natural heritage, we are proud to offer you this moment of purity in your busy lives.', CAST(250.00 AS Decimal(18, 2)), N'Packet', N'smallgrape.jpg', N'Italy', 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [About], [Price], [Type], [Image], [Origin], [EntityState]) VALUES (4, N'Capsicum', N'From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes. Thanks to this amazing journey through the Chambotte mountains, it acquires its unique fresgqualities. With our passion for preserving this natural heritage, we are proud to offer you this moment of purity in your busy lives.', CAST(360.00 AS Decimal(18, 2)), N'Packet', N'capsicum.png', N'India', 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [About], [Price], [Type], [Image], [Origin], [EntityState]) VALUES (5, N'Tomato', N'From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes. Thanks to this amazing journey through the Chambotte mountains, it acquires its unique fresgqualities. With our passion for preserving this natural heritage, we are proud to offer you this moment of purity in your busy lives.', CAST(200.00 AS Decimal(18, 2)), N'Packet', N'tomato.png', N'Bangladesh', 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [About], [Price], [Type], [Image], [Origin], [EntityState]) VALUES (6, N'Rose Apple', N'From the heart of the french Alps after a long journey.', CAST(150.00 AS Decimal(18, 2)), N'Packet', N'roseapple.png', N'Nepal', 1)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
USE [master]
GO
ALTER DATABASE [FarmFreshDB] SET  READ_WRITE 
GO
