USE [master]
GO
/****** Object:  Database [dbo_Ogrenci_Kayit_Sistemi]    Script Date: 20.10.2022 13:36:27 ******/
CREATE DATABASE [dbo_Ogrenci_Kayit_Sistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbo_Ogrenci_Kayit_Sistemi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbo_Ogrenci_Kayit_Sistemi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbo_Ogrenci_Kayit_Sistemi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbo_Ogrenci_Kayit_Sistemi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbo_Ogrenci_Kayit_Sistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET  MULTI_USER 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET QUERY_STORE = OFF
GO
USE [dbo_Ogrenci_Kayit_Sistemi]
GO
/****** Object:  Table [dbo].[Ogrenci_Bilgi]    Script Date: 20.10.2022 13:36:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci_Bilgi](
	[Ogrenci_id] [int] IDENTITY(1,1) NOT NULL,
	[Ogrenci_numara] [varchar](4) NULL,
	[Ogrenci_ad] [varchar](15) NULL,
	[Ogrenci_soyad] [varchar](20) NULL,
	[Sinav1] [tinyint] NULL,
	[Sinav2] [tinyint] NULL,
	[Sinav3] [tinyint] NULL,
	[Ortalama] [decimal](18, 2) NULL,
	[Durum] [bit] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [dbo_Ogrenci_Kayit_Sistemi] SET  READ_WRITE 
GO
