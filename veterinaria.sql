USE [master]
GO

/****** Object:  Database [VETERINARIA]    Script Date: 29/05/2021 18:47:19 ******/
CREATE DATABASE [VETERINARIA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VETERINARIA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\VETERINARIA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VETERINARIA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\VETERINARIA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VETERINARIA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [VETERINARIA] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [VETERINARIA] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [VETERINARIA] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [VETERINARIA] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [VETERINARIA] SET ARITHABORT OFF 
GO

ALTER DATABASE [VETERINARIA] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [VETERINARIA] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [VETERINARIA] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [VETERINARIA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [VETERINARIA] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [VETERINARIA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [VETERINARIA] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [VETERINARIA] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [VETERINARIA] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [VETERINARIA] SET  DISABLE_BROKER 
GO

ALTER DATABASE [VETERINARIA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [VETERINARIA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [VETERINARIA] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [VETERINARIA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [VETERINARIA] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [VETERINARIA] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [VETERINARIA] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [VETERINARIA] SET RECOVERY FULL 
GO

ALTER DATABASE [VETERINARIA] SET  MULTI_USER 
GO

ALTER DATABASE [VETERINARIA] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [VETERINARIA] SET DB_CHAINING OFF 
GO

ALTER DATABASE [VETERINARIA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [VETERINARIA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [VETERINARIA] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [VETERINARIA] SET QUERY_STORE = OFF
GO

ALTER DATABASE [VETERINARIA] SET  READ_WRITE 
GO

