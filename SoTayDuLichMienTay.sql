USE [master]
GO
/****** Object:  Database [SoTayDuLichMienTay]    Script Date: 10/27/2014 23:13:32 ******/
CREATE DATABASE [SoTayDuLichMienTay] ON  PRIMARY 
( NAME = N'SoTayDuLichMienTay', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SoTayDuLichMienTay.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SoTayDuLichMienTay_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SoTayDuLichMienTay_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SoTayDuLichMienTay] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SoTayDuLichMienTay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SoTayDuLichMienTay] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET ARITHABORT OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SoTayDuLichMienTay] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SoTayDuLichMienTay] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SoTayDuLichMienTay] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET  DISABLE_BROKER
GO
ALTER DATABASE [SoTayDuLichMienTay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SoTayDuLichMienTay] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SoTayDuLichMienTay] SET  READ_WRITE
GO
ALTER DATABASE [SoTayDuLichMienTay] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SoTayDuLichMienTay] SET  MULTI_USER
GO
ALTER DATABASE [SoTayDuLichMienTay] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SoTayDuLichMienTay] SET DB_CHAINING OFF
GO
USE [SoTayDuLichMienTay]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[age] [int] NOT NULL,
	[gender] [nvarchar](5) NOT NULL,
	[country] [nvarchar](20) NOT NULL,
	[role] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Province]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Province](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_Province] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CatePlace]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatePlace](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](200) NULL,
 CONSTRAINT [PK_CategoryProvince] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CateFood]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CateFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](1000) NULL,
 CONSTRAINT [PK_CateFood] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListUsers]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListUsers](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[idUser] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Like]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Like](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [int] NOT NULL,
	[idUser] [int] NOT NULL,
 CONSTRAINT [PK_Like] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[content] [nvarchar](4000) NOT NULL,
	[idUser] [int] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](1000) NULL,
	[like] [int] NOT NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Places]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](1000) NULL,
	[idProvince] [int] NOT NULL,
	[like] [int] NOT NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Place&Category]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place&Category](
	[placeName] [nvarchar](50) NOT NULL,
	[placeDes] [nvarchar](100) NOT NULL,
	[placeCate] [nvarchar](50) NOT NULL,
	[idPlace] [int] NOT NULL,
	[idPlaceCate] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food&Cate]    Script Date: 10/27/2014 23:13:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food&Cate](
	[foodName] [nvarchar](50) NOT NULL,
	[foofDes] [nvarchar](100) NOT NULL,
	[foodCat] [nvarchar](50) NOT NULL,
	[proName] [nvarchar](50) NOT NULL,
	[idFood] [int] NOT NULL,
	[idFoodCat] [int] NOT NULL,
	[foodProvince] [nvarchar](50) NOT NULL,
	[idProvince] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_ListUsers_User]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[ListUsers]  WITH CHECK ADD  CONSTRAINT [FK_ListUsers_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[ListUsers] CHECK CONSTRAINT [FK_ListUsers_User]
GO
/****** Object:  ForeignKey [FK_Like_User]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Like]  WITH CHECK ADD  CONSTRAINT [FK_Like_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Like] CHECK CONSTRAINT [FK_Like_User]
GO
/****** Object:  ForeignKey [FK_Comment_User]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User]
GO
/****** Object:  ForeignKey [FK_Food_Like]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_Like] FOREIGN KEY([like])
REFERENCES [dbo].[Like] ([id])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_Like]
GO
/****** Object:  ForeignKey [FK_Places_Like]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Places]  WITH CHECK ADD  CONSTRAINT [FK_Places_Like] FOREIGN KEY([like])
REFERENCES [dbo].[Like] ([id])
GO
ALTER TABLE [dbo].[Places] CHECK CONSTRAINT [FK_Places_Like]
GO
/****** Object:  ForeignKey [FK_Places_Province]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Places]  WITH CHECK ADD  CONSTRAINT [FK_Places_Province] FOREIGN KEY([idProvince])
REFERENCES [dbo].[Province] ([id])
GO
ALTER TABLE [dbo].[Places] CHECK CONSTRAINT [FK_Places_Province]
GO
/****** Object:  ForeignKey [FK_Place&Category_CatePlace]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Place&Category]  WITH CHECK ADD  CONSTRAINT [FK_Place&Category_CatePlace] FOREIGN KEY([idPlaceCate])
REFERENCES [dbo].[CatePlace] ([id])
GO
ALTER TABLE [dbo].[Place&Category] CHECK CONSTRAINT [FK_Place&Category_CatePlace]
GO
/****** Object:  ForeignKey [FK_Place&Category_Places]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Place&Category]  WITH CHECK ADD  CONSTRAINT [FK_Place&Category_Places] FOREIGN KEY([idPlace])
REFERENCES [dbo].[Places] ([id])
GO
ALTER TABLE [dbo].[Place&Category] CHECK CONSTRAINT [FK_Place&Category_Places]
GO
/****** Object:  ForeignKey [FK_Food&Cate_CateFood1]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Food&Cate]  WITH CHECK ADD  CONSTRAINT [FK_Food&Cate_CateFood1] FOREIGN KEY([idFoodCat])
REFERENCES [dbo].[CateFood] ([id])
GO
ALTER TABLE [dbo].[Food&Cate] CHECK CONSTRAINT [FK_Food&Cate_CateFood1]
GO
/****** Object:  ForeignKey [FK_Food&Cate_Food1]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Food&Cate]  WITH CHECK ADD  CONSTRAINT [FK_Food&Cate_Food1] FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food&Cate] CHECK CONSTRAINT [FK_Food&Cate_Food1]
GO
/****** Object:  ForeignKey [FK_Food&Cate_Province]    Script Date: 10/27/2014 23:13:33 ******/
ALTER TABLE [dbo].[Food&Cate]  WITH CHECK ADD  CONSTRAINT [FK_Food&Cate_Province] FOREIGN KEY([idProvince])
REFERENCES [dbo].[Province] ([id])
GO
ALTER TABLE [dbo].[Food&Cate] CHECK CONSTRAINT [FK_Food&Cate_Province]
GO
