USE [master]
GO

/****** Object:  Database [PeliculasDB]    Script Date: 8/7/2020 5:31:00 PM ******/
DROP DATABASE [PeliculasDB]
GO

/****** Object:  Database [PeliculasDB]    Script Date: 8/7/2020 5:31:00 PM ******/
CREATE DATABASE [PeliculasDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PeliculasDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.ISD\MSSQL\DATA\PeliculasDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PeliculasDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.ISD\MSSQL\DATA\PeliculasDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PeliculasDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [PeliculasDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PeliculasDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PeliculasDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PeliculasDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PeliculasDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [PeliculasDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PeliculasDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PeliculasDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PeliculasDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PeliculasDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PeliculasDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PeliculasDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PeliculasDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PeliculasDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PeliculasDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [PeliculasDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PeliculasDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PeliculasDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PeliculasDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PeliculasDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PeliculasDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [PeliculasDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PeliculasDB] SET RECOVERY FULL 
GO

ALTER DATABASE [PeliculasDB] SET  MULTI_USER 
GO

ALTER DATABASE [PeliculasDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PeliculasDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PeliculasDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PeliculasDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PeliculasDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PeliculasDB] SET QUERY_STORE = OFF
GO

USE [PeliculasDB]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [PeliculasDB] SET  READ_WRITE 
GO


