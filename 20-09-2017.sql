USE [master]
GO
/****** Object:  Database [JardinInfantes]    Script Date: 20/9/2017 3:44:19 a. m. ******/
CREATE DATABASE [JardinInfantes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JardinInfantes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS02\MSSQL\DATA\JardinInfantes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JardinInfantes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS02\MSSQL\DATA\JardinInfantes_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [JardinInfantes] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JardinInfantes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JardinInfantes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JardinInfantes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JardinInfantes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JardinInfantes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JardinInfantes] SET ARITHABORT OFF 
GO
ALTER DATABASE [JardinInfantes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [JardinInfantes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JardinInfantes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JardinInfantes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JardinInfantes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JardinInfantes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JardinInfantes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JardinInfantes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JardinInfantes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JardinInfantes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JardinInfantes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JardinInfantes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JardinInfantes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JardinInfantes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JardinInfantes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JardinInfantes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JardinInfantes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JardinInfantes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JardinInfantes] SET  MULTI_USER 
GO
ALTER DATABASE [JardinInfantes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JardinInfantes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JardinInfantes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JardinInfantes] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [JardinInfantes]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [JardinInfantes]
GO
/****** Object:  Table [dbo].[BackupS]    Script Date: 20/9/2017 3:44:19 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackupS](
	[ID_Backup] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Paths] [nvarchar](50) NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
	[NombreArchivo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Backup] PRIMARY KEY CLUSTERED 
(
	[ID_Backup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[ID_Evento] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Composite]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Composite](
	[ID_Composite] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Composite] PRIMARY KEY CLUSTERED 
(
	[ID_Composite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompositeFamilia]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompositeFamilia](
	[ID_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[ID_CompositeFamilia] [int] NULL,
	[ID_CompositePatente] [int] NULL,
 CONSTRAINT [PK_CompositeFamilia] PRIMARY KEY CLUSTERED 
(
	[ID_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DigitoVerificadorVertical]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DigitoVerificadorVertical](
	[ID_DigitoVerificadorVertical] [int] IDENTITY(1,1) NOT NULL,
	[NombreTabla] [nvarchar](50) NULL,
	[DigitoVerificadorV] [nvarchar](50) NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
 CONSTRAINT [PK_DigitoVerificadorVertical] PRIMARY KEY CLUSTERED 
(
	[ID_DigitoVerificadorVertical] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoBitacora](
	[ID_Evento] [int] IDENTITY(1,1) NOT NULL,
	[Evento] [nvarchar](50) NULL,
 CONSTRAINT [PK_EventoBitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] IDENTITY(1,1) NOT NULL,
	[Idioma] [nvarchar](50) NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Palabra]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palabra](
	[ID_Palabra] [int] IDENTITY(1,1) NOT NULL,
	[Palabra] [nvarchar](50) NULL,
 CONSTRAINT [PK_Palabra] PRIMARY KEY CLUSTERED 
(
	[ID_Palabra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[DNI] [int] NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
	[ID_Tipo_Persona] [int] NULL,
 CONSTRAINT [PK_TelefonoPersona] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreguntaSecreta]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntaSecreta](
	[ID_PreguntaSecreta] [int] IDENTITY(1,1) NOT NULL,
	[PreguntaSecreta] [nvarchar](50) NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
 CONSTRAINT [PK_PreguntaSecreta] PRIMARY KEY CLUSTERED 
(
	[ID_PreguntaSecreta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RespuestasSecreta]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RespuestasSecreta](
	[ID_RespuestaSecreta] [int] IDENTITY(1,1) NOT NULL,
	[ID_PreguntaSecreta] [int] NULL,
	[ID_Usuario] [int] NULL,
	[Respuesta] [nvarchar](max) NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
 CONSTRAINT [PK_RespuestasSecreta] PRIMARY KEY CLUSTERED 
(
	[ID_RespuestaSecreta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[ID_Telefono] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Pais] [int] NULL,
	[Numero] [int] NULL,
	[Descripcion] [nvarchar](50) NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[ID_Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TelefonoPersona]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefonoPersona](
	[Legajo] [int] NULL,
	[ID_Telefono] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoPersona]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPersona](
	[ID_Tipo_Persona] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipoPersona] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Idioma] [int] NOT NULL,
	[ID_Palabra] [int] NOT NULL,
	[Palabra] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](50) NULL,
	[Contraseña] [nvarchar](max) NULL,
	[IntentosFallidos] [int] NULL,
	[Logueado] [bit] NULL,
	[Legajo] [int] NULL,
	[DigitoVerificadorH] [nvarchar](50) NULL,
	[Bloqueado] [bit] NULL,
	[Habilitado] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioFamilia]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioFamilia](
	[ID_Usuario] [int] NULL,
	[ID_Permiso] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BackupS] ON 

INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (3, CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'C:\AMD', NULL, N'test.bak')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (4, CAST(N'2017-09-16T12:43:11.000' AS DateTime), N'C:\AMD', NULL, N'test.bak')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (5, CAST(N'2017-09-16T01:11:12.000' AS DateTime), N'C:\AMD', NULL, N'test.bak')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (6, CAST(N'2017-09-16T01:12:07.000' AS DateTime), N'C:\AMD', NULL, N'test2.bak')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (7, CAST(N'2017-09-16T01:12:07.000' AS DateTime), N'C:\AMD', NULL, N'test2.bak')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (8, CAST(N'2017-09-16T01:16:46.000' AS DateTime), N'C:\AMD', NULL, N'test3.bak')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (9, CAST(N'2017-09-16T01:18:50.000' AS DateTime), N'C:\AMD', NULL, N'test')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (10, CAST(N'2017-09-16T01:20:34.000' AS DateTime), N'C:\AMD', NULL, N'ter')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (11, CAST(N'2017-09-16T01:22:17.000' AS DateTime), N'C:\AMD', NULL, N'test')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (12, CAST(N'2017-09-16T01:24:26.000' AS DateTime), N'C:\AMD', NULL, N'estesiva')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (13, CAST(N'2017-09-16T01:31:12.000' AS DateTime), N'C:\AMD', NULL, N'ret')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (14, CAST(N'2017-09-16T22:53:21.000' AS DateTime), N'C:\KOGGAMES', NULL, N'ver')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (15, CAST(N'2017-09-16T22:55:20.000' AS DateTime), N'C:\TEMP', NULL, N'gre')
INSERT [dbo].[BackupS] ([ID_Backup], [Fecha], [Paths], [DigitoVerificadorH], [NombreArchivo]) VALUES (16, CAST(N'2017-09-19T01:39:18.000' AS DateTime), N'C:\Users\andres\Documents\GitHub\Jardin', NULL, N'19-9-2017')
SET IDENTITY_INSERT [dbo].[BackupS] OFF
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (22, 3, 1, CAST(N'2017-09-16T00:16:58.877' AS DateTime), N'5142387304f207c01a003c441d4818a0', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (23, 3, 1, CAST(N'2017-09-16T00:19:55.507' AS DateTime), N'eca3cef312255b4208b705c5602aacc4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (24, 3, 1, CAST(N'2017-09-16T00:21:15.010' AS DateTime), N'9fa5d4b25b70492e1764fb354b9df75b', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (25, 3, 1, CAST(N'2017-09-16T00:22:29.907' AS DateTime), N'66bf61216f55a207718c4dcde3645ef1', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (26, 3, 1, CAST(N'2017-09-16T00:23:23.777' AS DateTime), N'952103c05da78de4f518e126033120ad', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (27, 3, 1, CAST(N'2017-09-16T00:24:52.427' AS DateTime), N'd5ddd469f0c632fda132218dc091a15e', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (28, 3, 1, CAST(N'2017-09-16T00:28:25.320' AS DateTime), N'160905f36e95563452e26aaf0978ada3', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (29, 3, 1, CAST(N'2017-09-16T00:31:15.507' AS DateTime), N'479b3936c6c479083bd19e3111801fbd', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (30, 3, 1, CAST(N'2017-09-16T00:32:14.967' AS DateTime), N'5566bdae74b43b7568913d8de77c9105', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (31, 3, 1, CAST(N'2017-09-16T00:33:16.920' AS DateTime), N'b47b45337c56384702909f5753f3496d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (32, 8, 1, CAST(N'2017-09-16T00:34:35.763' AS DateTime), N'91dd06e21ae59f6f74b06f67d06da470', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (33, 8, 1, CAST(N'2017-09-16T00:34:35.783' AS DateTime), N'c7253334eee5151169102990ed1982f5', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (34, 3, 1, CAST(N'2017-09-16T00:34:42.403' AS DateTime), N'1038c4dccf01a539c23171b4012369d4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (35, 3, 1, CAST(N'2017-09-16T00:35:30.470' AS DateTime), N'b49cb5ce63148a4fa6f384a3fa907213', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (36, 3, 1, CAST(N'2017-09-16T00:38:53.013' AS DateTime), N'60f58627d7adc3a5dd06fb2d33257e2f', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (37, 3, 1, CAST(N'2017-09-16T00:40:47.783' AS DateTime), N'fbaa5a2d0f26900938580b7a733a7454', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (38, 3, 1, CAST(N'2017-09-16T00:42:56.650' AS DateTime), N'23c10a39325bf205c14f76ba44b0d88c', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (39, 3, 1, CAST(N'2017-09-16T00:56:50.367' AS DateTime), N'560d22bc8dca311f57071878d6e45333', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (40, 3, 1, CAST(N'2017-09-16T00:59:45.413' AS DateTime), N'4b37525c62ac0a474926dd16b48238b1', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (41, 3, 1, CAST(N'2017-09-16T01:02:20.990' AS DateTime), N'b3268d811270d8b27eea0a169b761825', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (42, 3, 1, CAST(N'2017-09-16T01:05:58.640' AS DateTime), N'6cf857220014ef6b5fae77fa01aa5fee', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (43, 3, 1, CAST(N'2017-09-16T01:07:42.700' AS DateTime), N'ea2f039013bdc50b12fbf7b2db16c04c', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (44, 3, 1, CAST(N'2017-09-16T01:10:39.980' AS DateTime), N'2cf515a720df066caa840d88eba9898a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (45, 3, 1, CAST(N'2017-09-16T01:11:47.037' AS DateTime), N'd9eb5c7a82193789dac7263210f97638', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (46, 3, 1, CAST(N'2017-09-16T01:16:29.020' AS DateTime), N'67260bd1bb035ca17e9edff8a2cfc96e', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (47, 3, 1, CAST(N'2017-09-16T01:18:24.500' AS DateTime), N'0e70385a60b75f95eee3d6f30215faa9', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (48, 3, 1, CAST(N'2017-09-16T01:20:14.993' AS DateTime), N'8274780f73936ba71d72b096b3ac7d83', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (49, 3, 1, CAST(N'2017-09-16T01:22:00.913' AS DateTime), N'd27d99fc3469cba093c02e2ce9fce0f5', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (50, 3, 1, CAST(N'2017-09-16T01:24:10.073' AS DateTime), N'8320e07c80cbd51fa3b8a6967ca909c7', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (51, 9, 1, CAST(N'2017-09-16T01:24:39.403' AS DateTime), N'c527686ced21efcef88d8946fee3679f', N'Se generar un Backup')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (52, 3, 1, CAST(N'2017-09-16T01:30:56.420' AS DateTime), N'46bd5e778dedde0fb9e6208e4d9ed7c4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (53, 9, 1, CAST(N'2017-09-16T01:31:25.500' AS DateTime), N'dbf70e46bce22d6fc37c9772657673ef', N'Se generar un Backup')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (54, 3, 1, CAST(N'2017-09-16T22:52:57.367' AS DateTime), N'760a8d30d73cbb9b1d15418b0d59474a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (55, 8, 1, CAST(N'2017-09-16T22:54:54.157' AS DateTime), N'c1ecbeda0362466576a9b8b4873de473', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (56, 8, 1, CAST(N'2017-09-16T22:54:54.227' AS DateTime), N'f51987a9fc9b06cdf7412fe5ffcbab7b', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (57, 3, 1, CAST(N'2017-09-16T22:54:58.990' AS DateTime), N'6195b5466c0ed9583f5dc48cbfce6096', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (58, 9, 1, CAST(N'2017-09-16T22:55:53.033' AS DateTime), N'c7f648cf8a7ae131f24d3c4d12ea375c', N'Se generar un Backup')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (59, 3, 1, CAST(N'2017-09-16T22:59:07.187' AS DateTime), N'615101d4b329d8173763d1ec4e225a5a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (60, 3, 1, CAST(N'2017-09-16T23:01:55.943' AS DateTime), N'3f06cdf4bc4fe064a7acfb6e4dbd55c6', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (61, 10, 1, CAST(N'2017-09-16T23:02:30.677' AS DateTime), N'0eaed8a15f468478fbd4536915389914', N'Se restaura un Backup')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (62, 3, 1, CAST(N'2017-09-16T23:03:11.703' AS DateTime), N'd5ebdaeda12f279c327bd23f0a5c9c65', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (63, 10, 1, CAST(N'2017-09-16T23:03:47.033' AS DateTime), N'91478aced64c026a466428917f123d2e', N'Se restaura un Backup')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (64, 3, 1, CAST(N'2017-09-16T23:13:29.347' AS DateTime), N'96103af79c27048fa8f8c23f4a3fcfd4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (65, 3, 1, CAST(N'2017-09-16T23:52:19.020' AS DateTime), N'b9a7fb1c362a48fdd3e54598a41f72c4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (66, 3, 1, CAST(N'2017-09-16T23:53:51.180' AS DateTime), N'03462cd508467bea622d79d2fd7e4e96', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (67, 3, 1, CAST(N'2017-09-16T23:55:35.793' AS DateTime), N'b3f4ba838b2d6fa7e2eecd0164ff5f39', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (68, 3, 1, CAST(N'2017-09-17T00:57:37.247' AS DateTime), N'c86125e221c6242b1e92b05e7f08524a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (69, 3, 1, CAST(N'2017-09-17T01:01:23.417' AS DateTime), N'6ea2cefa541ac6fed9bb977e7b790da3', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (70, 3, 1, CAST(N'2017-09-17T21:33:57.440' AS DateTime), N'd7c6dab27339971827d26a4c73795997', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (71, 3, 1, CAST(N'2017-09-17T21:38:37.477' AS DateTime), N'd2f83f2442cd7ed30ffdca2a0668410d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (72, 3, 1, CAST(N'2017-09-17T21:43:35.493' AS DateTime), N'5b923e15586c13b47d5e8bef1510da15', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (73, 7, 1, CAST(N'2017-09-17T21:43:35.520' AS DateTime), N'4db8e1d5fccdf5b38f154aedaa951230', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (74, 3, 1, CAST(N'2017-09-17T21:43:42.217' AS DateTime), N'a0aec3be0f63e2f68e09be658f66e59f', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (75, 7, 1, CAST(N'2017-09-17T21:43:42.233' AS DateTime), N'c86db5d50d5975d790182b7fdcdcc030', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (76, 3, 1, CAST(N'2017-09-17T21:43:58.090' AS DateTime), N'025eed4844e2eca08cfcb2e23a5dbe17', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (77, 7, 1, CAST(N'2017-09-17T21:43:58.097' AS DateTime), N'5ec3722b61acf46e203c6a7cb6db7bec', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (78, 8, 1, CAST(N'2017-09-17T21:46:15.740' AS DateTime), N'3305ac1c8b6c18805c8989458a3e5dd4', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (79, 8, 1, CAST(N'2017-09-17T21:46:15.770' AS DateTime), N'81f8142c5d830b3a82cca6c35d6faa1a', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (80, 8, 1, CAST(N'2017-09-17T21:46:56.417' AS DateTime), N'7592a233f28244c561bdf4dc3e2315d4', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (81, 8, 1, CAST(N'2017-09-17T21:46:56.443' AS DateTime), N'fb8a835f915a6c7d4e15ddae9ae93f49', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (82, 3, 1, CAST(N'2017-09-17T21:50:29.023' AS DateTime), N'f4c1fbcd37b0eba444236faee01f22b7', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (83, 7, 1, CAST(N'2017-09-17T21:50:29.057' AS DateTime), N'e6505df6e9c2364547bc34772c59ef44', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (84, 3, 1, CAST(N'2017-09-17T21:51:48.337' AS DateTime), N'8816b711a466aa43f4b63730114ef49d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (85, 7, 1, CAST(N'2017-09-17T21:51:48.360' AS DateTime), N'1f8017133d781868ab410634f546bb3b', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (86, 3, 1, CAST(N'2017-09-17T21:53:11.560' AS DateTime), N'9727d40d6a7480d197868d5d9c2c7074', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (87, 3, 1, CAST(N'2017-09-17T21:55:56.573' AS DateTime), N'707be5f7aa1707690d42b5ac0583be16', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (88, 7, 1, CAST(N'2017-09-17T21:58:23.683' AS DateTime), N'57b61ef4df3d4ef5e4cf4498a72aa7cd', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (89, 3, 1, CAST(N'2017-09-17T21:58:24.867' AS DateTime), N'5ca89ac45c12b333d6a0cbff3a38ef74', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (90, 7, 1, CAST(N'2017-09-17T21:58:41.583' AS DateTime), N'ee11c3c80e5ec2c253a79813208035a8', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (91, 3, 1, CAST(N'2017-09-17T21:58:41.640' AS DateTime), N'62ab3e327e32ca9f51fb120ef24e1ca4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (92, 7, 1, CAST(N'2017-09-17T21:58:41.650' AS DateTime), N'0e9dae352cbea5603a70d8461b694b6f', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (93, 3, 1, CAST(N'2017-09-17T21:58:46.253' AS DateTime), N'4a2d272605ac373be5ef709e61a32f39', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (94, 7, 1, CAST(N'2017-09-17T21:58:46.270' AS DateTime), N'd4b1f1c1d753c1fe0f4808c07d5f5136', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (95, 3, 1, CAST(N'2017-09-17T22:00:37.017' AS DateTime), N'25f2c8061289325606eb7a3f2341fde3', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (96, 7, 1, CAST(N'2017-09-17T22:00:51.873' AS DateTime), N'f5fc046153fffb93a967c00261352591', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (97, 3, 1, CAST(N'2017-09-17T22:01:02.037' AS DateTime), N'048eee9df802ee6cc6314938db217e8f', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (98, 7, 1, CAST(N'2017-09-17T22:02:01.307' AS DateTime), N'66cece54ba8baa00ead4172921df2af4', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (99, 3, 1, CAST(N'2017-09-17T22:03:07.783' AS DateTime), N'013ae01907b67809c00ab08c594b34b2', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (100, 7, 1, CAST(N'2017-09-17T22:04:54.720' AS DateTime), N'c7c3e0829687a9c3f1e4f13b7e79aec3', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (101, 3, 1, CAST(N'2017-09-17T22:04:58.083' AS DateTime), N'8be2b7102cd14ce7861b93d68ba40d61', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (102, 3, 7, CAST(N'2017-09-17T22:21:51.060' AS DateTime), N'3a099a7453f73bb979956b5ebb22115c', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (103, 3, 1, CAST(N'2017-09-17T22:32:17.970' AS DateTime), N'eb30c26327a7e66ada717157c90cb8ec', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (104, 7, 1, CAST(N'2017-09-17T22:32:18.000' AS DateTime), N'8ea86907ffbb483beb6a8eb2b6bb452e', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (105, 3, 1, CAST(N'2017-09-17T22:32:40.117' AS DateTime), N'32a81a6b79fa79d6986eb1ea0426d7c5', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (106, 7, 1, CAST(N'2017-09-17T22:32:40.133' AS DateTime), N'3c14b333aa2b95be708009c4f7ffb22f', N'error en la consistencia de datos al loguearse')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (107, 3, 1, CAST(N'2017-09-17T22:35:49.633' AS DateTime), N'dffc812ced312434ecdba09c14500a32', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (108, 3, 1, CAST(N'2017-09-17T22:37:48.743' AS DateTime), N'd6b15f5d9fad76ca011165d43bb87a40', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (109, 3, 1, CAST(N'2017-09-17T22:42:28.470' AS DateTime), N'db3e4cab5f5b491bde51a3c4dc7f680a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (110, 3, 1, CAST(N'2017-09-17T22:48:15.500' AS DateTime), N'5846e5c05d1b132fedf43127767a2c02', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (111, 3, 7, CAST(N'2017-09-17T22:48:39.927' AS DateTime), N'da8599d250d26cff1dae6261901a1cab', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (112, 3, 1, CAST(N'2017-09-17T22:50:50.590' AS DateTime), N'e3dda741b72029ef1899ebbb2c46fde9', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (113, 3, 1, CAST(N'2017-09-17T22:55:53.383' AS DateTime), N'b76957d2285d45f46608133a322ae4a0', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (114, 3, 1, CAST(N'2017-09-17T22:57:05.623' AS DateTime), N'3b3ae7c523a3b21bf6299ea1fe36c374', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (115, 3, 1, CAST(N'2017-09-17T23:11:34.907' AS DateTime), N'67a0a1fb4c2be734fef1ddb2303653b6', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (116, 3, 1, CAST(N'2017-09-17T23:13:33.687' AS DateTime), N'4fefd589fddfdb3be279eb9853dcc433', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (117, 11, 1, CAST(N'2017-09-17T23:14:19.480' AS DateTime), N'f487d90c6d25734cc1838eb801cf9735', N'Se dio de baja')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (118, 11, 1, CAST(N'2017-09-17T23:15:35.397' AS DateTime), N'b76d6d0e211954dae868eefda0b4818e', N'Se dio de baja')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (119, 3, 1, CAST(N'2017-09-17T23:17:57.100' AS DateTime), N'b4ebd6c996ef34eb4c42a9f9ee3b2a7b', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (120, 3, 1, CAST(N'2017-09-17T23:19:49.813' AS DateTime), N'a326b53ef5291083ce8d7344a795e4b1', N'Se logueo Correctamente')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (122, 3, 1, CAST(N'2017-09-17T23:25:18.157' AS DateTime), N'3f5566483f1bb1a4e96b7b564d53b879', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (124, 3, 1, CAST(N'2017-09-17T23:27:57.160' AS DateTime), N'65d3b80b62fb4ddead45a2b92fbaf375', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (126, 3, 1, CAST(N'2017-09-17T23:29:36.557' AS DateTime), N'36fce3755b0ac1548492b0fbe8ff810d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (128, 3, 7, CAST(N'2017-09-17T23:31:42.293' AS DateTime), N'a9f4a3fd93a6c56cb5f74bbd2b68d2f9', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (129, 12, 7, CAST(N'2017-09-17T23:32:01.077' AS DateTime), N'92d412fc3b761ac62fb461a3fbcddfe6', N'Se Modifico')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (130, 3, 1, CAST(N'2017-09-17T23:33:02.343' AS DateTime), N'c849b171f93cc1467938767089a8e153', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (131, 11, 1, CAST(N'2017-09-17T23:33:41.623' AS DateTime), N'af9029cfced66f211d7d7080acef80f4', N'Se dio de baja')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (132, 3, 1, CAST(N'2017-09-17T23:37:52.023' AS DateTime), N'8cf45cbf3f2e7e651cc2b35c306cd4e8', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (133, 3, 1, CAST(N'2017-09-17T23:39:13.253' AS DateTime), N'eb029537257a2f8f939487f88741445b', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (134, 3, 1, CAST(N'2017-09-17T23:41:02.980' AS DateTime), N'bacb4630b162d4a056806f7b3d4507b4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (135, 3, 1, CAST(N'2017-09-17T23:42:56.737' AS DateTime), N'02b4bad59a0293787a47d3f3d93d751a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (136, 11, 1, CAST(N'2017-09-17T23:48:19.053' AS DateTime), N'22e1ca5b059deaf274e26b56f8bcbf4d', N'Se dio de baja')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (137, 3, 1, CAST(N'2017-09-17T23:49:03.693' AS DateTime), N'822a4169a41d90ebb54e9df4fd82417c', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (138, 8, 1, CAST(N'2017-09-18T00:09:33.763' AS DateTime), N'828d829d5299dca2326b2c6e939c3ec1', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (139, 8, 1, CAST(N'2017-09-18T00:09:33.793' AS DateTime), N'c611e6e91d600dd55ed3131ffe2a5acf', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (140, 3, 1, CAST(N'2017-09-18T00:09:43.923' AS DateTime), N'88c299937644dcbb5b6be064619f2fb6', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (141, 3, 1, CAST(N'2017-09-18T00:12:46.120' AS DateTime), N'fc3eeecce7cad71282c866e62e57b04d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (142, 8, 1, CAST(N'2017-09-18T00:14:23.203' AS DateTime), N'25c5ffc429e9dc140922672ef8d57424', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (143, 8, 1, CAST(N'2017-09-18T00:14:23.223' AS DateTime), N'9070ec5dd4b56c3b97317561353761f1', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (144, 3, 1, CAST(N'2017-09-18T00:14:30.087' AS DateTime), N'0954e7de84a8ce0bbecaa18109b3d4ff', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (145, 11, 1, CAST(N'2017-09-18T00:14:50.997' AS DateTime), N'c23128bef8cfa159dc5b32e23c5ac92f', N'Se dio de baja')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (146, 3, 1, CAST(N'2017-09-18T00:18:09.737' AS DateTime), N'ebf3b479ab67982e1d915a5ab2256614', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (147, 11, 1, CAST(N'2017-09-18T00:18:27.550' AS DateTime), N'7ef058036faf4df73fb7bb4aa90bc2a0', N'Se dio de baja')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (148, 3, 1, CAST(N'2017-09-18T00:21:03.790' AS DateTime), N'0eaf743cb4211119d97ff93d537634e4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (149, 3, 1, CAST(N'2017-09-18T00:44:32.523' AS DateTime), N'1445a58e7590e161eea63d26f62cfe1d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (150, 8, 1, CAST(N'2017-09-18T00:49:35.290' AS DateTime), N'0226e33f0de0f95c06db572a25241ab6', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (151, 8, 1, CAST(N'2017-09-18T00:49:35.313' AS DateTime), N'7e3e47f774b79b1d5b5b1767ec8b1676', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (152, 8, 1, CAST(N'2017-09-18T00:49:44.590' AS DateTime), N'e0c136b6df1908a559e2e91c2a572fbb', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (153, 8, 1, CAST(N'2017-09-18T00:49:44.610' AS DateTime), N'46d9e2b55c8ba983a91a5623382ebd3f', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (154, 3, 1, CAST(N'2017-09-18T00:49:50.170' AS DateTime), N'5eb62bce9cba94080352fb3664c1ae29', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (155, 3, 1, CAST(N'2017-09-18T00:50:55.700' AS DateTime), N'c01bdba693a6193024d19a46a5b18918', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (156, 3, 1, CAST(N'2017-09-18T00:51:52.003' AS DateTime), N'592a1b02168ba61ec3cbe6336b28afcf', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (157, 3, 1, CAST(N'2017-09-19T00:05:18.853' AS DateTime), N'5b67e12a7ab608cd3497035a5a2888af', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (158, 3, 1, CAST(N'2017-09-19T00:06:57.530' AS DateTime), N'd340538a32f584519e8f9919f427d22a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (159, 3, 1, CAST(N'2017-09-19T00:33:42.843' AS DateTime), N'9e284ebeb6015b89dd50c89e5903cb37', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (160, 3, 1, CAST(N'2017-09-19T00:36:18.780' AS DateTime), N'8fcde0ad8241cd570597172a442c5c01', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (161, 8, 1, CAST(N'2017-09-19T00:39:22.360' AS DateTime), N'63dae730eef1bd2833bd5b64fb788b48', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (162, 8, 1, CAST(N'2017-09-19T00:39:22.387' AS DateTime), N'3b783dcde4128e6d4fdeb54cd1668b8e', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (163, 3, 1, CAST(N'2017-09-19T00:39:29.667' AS DateTime), N'57f9144db323962375ef14d2b24be6d2', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (164, 3, 1, CAST(N'2017-09-19T01:06:52.803' AS DateTime), N'287d61367bd33f81c2c47eda15501747', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (165, 3, 1, CAST(N'2017-09-19T01:08:07.623' AS DateTime), N'992a46aaff99f3ace94b7c0e51666a04', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (166, 3, 1, CAST(N'2017-09-19T01:10:10.490' AS DateTime), N'6894466a9d112236c58125d098edf808', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (167, 3, 1, CAST(N'2017-09-19T01:14:39.997' AS DateTime), N'5b8892452c662172fbe6629b392e9100', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (168, 8, 1, CAST(N'2017-09-19T01:18:48.957' AS DateTime), N'1e630aa08d9509401d6d0c6440a58656', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (169, 8, 1, CAST(N'2017-09-19T01:18:48.980' AS DateTime), N'c4c324bbcbb1c39056e0a04d588780aa', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (170, 3, 1, CAST(N'2017-09-19T01:18:57.213' AS DateTime), N'596e626d2cb75d1980225802f8b674ca', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (171, 3, 1, CAST(N'2017-09-19T01:20:55.320' AS DateTime), N'fe9e822ad14b20ff89ea5a3e4cff3608', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (172, 3, 1, CAST(N'2017-09-19T01:23:02.593' AS DateTime), N'c44aabacd1ceed90f2b265e8c057e189', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (173, 3, 1, CAST(N'2017-09-19T01:25:14.220' AS DateTime), N'15ef310949d7aa36080489c299debb65', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (174, 8, 1, CAST(N'2017-09-19T01:27:30.383' AS DateTime), N'4612cadbcb1cf7c9920817b0acd97b26', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (175, 8, 1, CAST(N'2017-09-19T01:27:30.410' AS DateTime), N'd1684d3d25974fbdb20267d7d9713c41', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (176, 3, 1, CAST(N'2017-09-19T01:27:41.867' AS DateTime), N'960a224e1bbfc95b1cfeaec063cb0061', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (177, 3, 1, CAST(N'2017-09-19T01:28:55.397' AS DateTime), N'c6755ec1329de23347c6f5cf11380a2d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (178, 3, 1, CAST(N'2017-09-19T01:29:52.773' AS DateTime), N'e3739096015898813230f7e354c8873a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (179, 3, 1, CAST(N'2017-09-19T01:36:53.313' AS DateTime), N'0a8d1df587458f031c6630f4cecc2310', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (180, 3, 1, CAST(N'2017-09-19T01:38:02.807' AS DateTime), N'd6f4af08359bb5ece5da411b98e16b56', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (181, 9, 1, CAST(N'2017-09-19T01:39:22.123' AS DateTime), N'38fb10397024b25666cd166ed2809f7d', N'Se generar un Backup')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (182, 3, 1, CAST(N'2017-09-20T00:03:34.120' AS DateTime), N'e987376b53bf8e8c69c6c7d6f83e3bbc', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (183, 3, 1, CAST(N'2017-09-20T00:05:39.083' AS DateTime), N'8e471fbdbecf679852ebe5abdd6ea012', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (184, 3, 1, CAST(N'2017-09-20T00:10:07.090' AS DateTime), N'66c338487473071ecddb5b7d2841f9ed', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (185, 3, 1, CAST(N'2017-09-20T00:12:53.723' AS DateTime), N'2be7cde35564f066a5dca09cc5cb21a2', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (186, 3, 1, CAST(N'2017-09-20T00:13:50.960' AS DateTime), N'9e1fd8f389c6f8fb8dd00811428e8c48', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (187, 3, 1, CAST(N'2017-09-20T00:32:20.983' AS DateTime), N'9cd5d5b4c9eda85834039ab788296806', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (188, 3, 1, CAST(N'2017-09-20T00:33:31.843' AS DateTime), N'41c682f9d8d66144b08d0d6628cd0453', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (189, 8, 1, CAST(N'2017-09-20T00:36:10.957' AS DateTime), N'6502f5ed40f91e9fc207e3d7846440a1', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (190, 8, 1, CAST(N'2017-09-20T00:36:10.977' AS DateTime), N'1a49c68dc1a753ce3c84a7611f2e28f8', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (191, 3, 1, CAST(N'2017-09-20T00:36:17.707' AS DateTime), N'8316bf928c9fce323cc12a9731ddfbcc', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (192, 3, 1, CAST(N'2017-09-20T00:38:46.090' AS DateTime), N'95093d48bb3cafe29c87f9ce093c7f5d', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (193, 3, 1, CAST(N'2017-09-20T00:40:33.597' AS DateTime), N'5e3db70f9bf3ef49da2a524ba04329df', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (194, 3, 1, CAST(N'2017-09-20T00:47:03.647' AS DateTime), N'a9cf1f6b9915ff12ac373d9097581ea3', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (195, 3, 1, CAST(N'2017-09-20T00:50:38.917' AS DateTime), N'6befece8914e77efb890ddd5480fe2bf', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (196, 3, 1, CAST(N'2017-09-20T00:53:50.443' AS DateTime), N'9f0885e5948a0a739b0bfba8f4660904', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (197, 3, 1, CAST(N'2017-09-20T01:08:30.610' AS DateTime), N'4b5fe94fc2e709c38424621a61f8d07b', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (198, 3, 1, CAST(N'2017-09-20T01:15:28.670' AS DateTime), N'49b78aea45ecb39b7dbc5e91a1e59fbc', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (199, 3, 1, CAST(N'2017-09-20T01:18:22.930' AS DateTime), N'0524f7d306cac3b855ec4dc328efe3fa', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (200, 3, 1, CAST(N'2017-09-20T01:27:27.110' AS DateTime), N'f14a2d7d673ff7f24a723ba972b9dc94', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (201, 3, 1, CAST(N'2017-09-20T01:30:48.253' AS DateTime), N'43c08aff8629affeaeebfa8f431e2ac6', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (202, 8, 1, CAST(N'2017-09-20T01:45:07.180' AS DateTime), N'9aed5b20560dd687cd3d94b2ccc33551', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (203, 8, 1, CAST(N'2017-09-20T01:45:07.197' AS DateTime), N'3f45e0e8b74d763067fdcca0b6d00b6b', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (204, 3, 1, CAST(N'2017-09-20T01:45:16.300' AS DateTime), N'995e72d68dde5ee423789421172eb192', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (205, 3, 1, CAST(N'2017-09-20T01:49:35.487' AS DateTime), N'6ea777194127583f665ecc383f23c1f4', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (206, 3, 1, CAST(N'2017-09-20T01:50:43.343' AS DateTime), N'c46000d5135f8ed37660ee5376779f54', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (207, 3, 1, CAST(N'2017-09-20T01:52:19.883' AS DateTime), N'6aefc205b5f220a9a58630b672fb52a7', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (208, 3, 1, CAST(N'2017-09-20T02:39:41.813' AS DateTime), N'2270d1acad2c2b2f34ead420bfa5182f', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (209, 3, 1, CAST(N'2017-09-20T02:43:33.963' AS DateTime), N'cc7ab2e84163b878c1f90e8a4897634a', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (210, 3, 1, CAST(N'2017-09-20T02:46:01.083' AS DateTime), N'caa70d2712970a055c2bbbc24ae2e0bd', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (211, 3, 1, CAST(N'2017-09-20T02:47:51.693' AS DateTime), N'48e71323be94d4826619835c79544f23', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (212, 3, 1, CAST(N'2017-09-20T02:49:20.517' AS DateTime), N'6e1c7ba57bd4e4fc1bbfe690ff21b8f7', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (213, 8, 1, CAST(N'2017-09-20T03:03:11.530' AS DateTime), N'0b1c24e9efc134b00bab39f0cc528ea5', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (214, 8, 1, CAST(N'2017-09-20T03:03:11.547' AS DateTime), N'258b5e47dd30e2611c228986863c39e9', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (215, 3, 1, CAST(N'2017-09-20T03:03:19.533' AS DateTime), N'5176137fc6fb0949e0873b1a02bd54f6', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (216, 3, 1, CAST(N'2017-09-20T03:04:19.730' AS DateTime), N'6d760ec3d0a564ed8860fc74a8ddf029', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (217, 3, 1, CAST(N'2017-09-20T03:11:43.563' AS DateTime), N'45fc1afae3bc5b36183a783d853debe1', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (218, 3, 1, CAST(N'2017-09-20T03:18:01.273' AS DateTime), N'f4511612871e81f8994d558e1437ef53', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (219, 3, 1, CAST(N'2017-09-20T03:19:47.857' AS DateTime), N'5268bf618a8502e47e6af377c09c39f2', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (220, 8, 1, CAST(N'2017-09-20T03:21:36.227' AS DateTime), N'e6e814b966a733daa5b2677095756676', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (221, 8, 1, CAST(N'2017-09-20T03:21:36.247' AS DateTime), N'2d5a932174246fefa8a35fac1053ce85', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (222, 8, 1, CAST(N'2017-09-20T03:26:12.707' AS DateTime), N'f2cc0b690727127f216aed02e59def42', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (223, 8, 1, CAST(N'2017-09-20T03:26:12.723' AS DateTime), N'da7a28cd181d53e49fe95e5b35cc8a40', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (224, 3, 1, CAST(N'2017-09-20T03:26:20.310' AS DateTime), N'cbf893c8372d2d1b19ed7f605a9e1d3b', N'Se logueo Correctamente')
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (225, 8, 1, CAST(N'2017-09-20T03:27:11.023' AS DateTime), N'7dc44be8580424b8cbae5a3d97389b10', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (226, 8, 1, CAST(N'2017-09-20T03:27:11.043' AS DateTime), N'77eb9d182fbe003f15d1d4802be74dd0', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (227, 3, 1, CAST(N'2017-09-20T03:27:17.553' AS DateTime), N'cef062a5961e248ab92c3548e34362a6', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (228, 3, 1, CAST(N'2017-09-20T03:29:39.900' AS DateTime), N'e124e9930e7be46f8d6449ef204a95e2', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (229, 8, 1, CAST(N'2017-09-20T03:31:08.303' AS DateTime), N'7de0284de07a0b73affc34d25c0869fc', N'Se ha ingresado mal la contraseña')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (230, 8, 1, CAST(N'2017-09-20T03:31:08.320' AS DateTime), N'a3cd845b3e040f06178a0d1b8d941a12', N'Ha ingresado una contraseña erronea')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (231, 3, 1, CAST(N'2017-09-20T03:31:15.383' AS DateTime), N'57df013281552a55d3e8d81e90fc912c', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (232, 3, 1, CAST(N'2017-09-20T03:33:36.057' AS DateTime), N'78a9ca1ee877800f1c5a0c2f72bb8f87', N'Se logueo Correctamente')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH], [Descripcion]) VALUES (233, 3, 1, CAST(N'2017-09-20T03:37:14.897' AS DateTime), N'046ba5b5237bb05fdb1c3567f73a1c5d', N'Se logueo Correctamente')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[Composite] ON 

INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (1, N'Servicios', N'Acceso a la configuracion del programa', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (2, N'Gestion de Alumnos', N'Acceso a gestionar los alumnos', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (3, N'Administrador', N'Acceso a todo el sistema', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (4, N'Secretaria', N'Acceso a la administracion', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (5, N'Personal Docente', N'Acceso a la gestion de notas y salas', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (6, N'Gestion mantenimiento', N'Acceso a la gestion Mantenimiento', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (7, N'Personal no Docente', N'Acceso a mantenimiento', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (8, N'Gestion Ventas', N'Pagos generales', 1)
INSERT [dbo].[Composite] ([ID_Composite], [Nombre], [Descripcion], [Activo]) VALUES (9, N'Gestion Intitucional', N'Gestion de aulas, salas, comisones', 1)
SET IDENTITY_INSERT [dbo].[Composite] OFF
SET IDENTITY_INSERT [dbo].[CompositeFamilia] ON 

INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (1, 3, 1)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (2, 3, 2)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (3, 3, NULL)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (4, 4, 2)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (5, 4, NULL)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (6, 5, NULL)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (7, 3, 6)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (8, 7, NULL)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (9, NULL, 1)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (10, NULL, 2)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (11, NULL, 6)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (12, NULL, 8)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (13, NULL, 9)
INSERT [dbo].[CompositeFamilia] ([ID_Permiso], [ID_CompositeFamilia], [ID_CompositePatente]) VALUES (21, 3, 9)
SET IDENTITY_INSERT [dbo].[CompositeFamilia] OFF
SET IDENTITY_INSERT [dbo].[DigitoVerificadorVertical] ON 

INSERT [dbo].[DigitoVerificadorVertical] ([ID_DigitoVerificadorVertical], [NombreTabla], [DigitoVerificadorV], [DigitoVerificadorH]) VALUES (1, N'Usuario', N'Sarasa', NULL)
SET IDENTITY_INSERT [dbo].[DigitoVerificadorVertical] OFF
SET IDENTITY_INSERT [dbo].[EventoBitacora] ON 

INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (1, N'Alta usuario')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (2, N'Asignar Permiso')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (3, N'Login')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (4, N'Logout')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (5, N'Error Digito Verificador Horizontal')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (6, N'Usuario bloqueado')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (7, N'Error Digito Verificador Vertical')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (8, N'Contraseña incorrecta')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (9, N'Generar Backup')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (10, N'Restaurar Backup')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (11, N'Baja Usuario')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (12, N'Modificar Usuario')
INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (13, N'')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (1, N'es-AR')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (2, N'pt-BR')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (3, N'es-US')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (4, N'CA')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (1006, N'FR-fr')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (1021, N'dsdvf')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
SET IDENTITY_INSERT [dbo].[Palabra] ON 

INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1, N'Aceptar')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (2, N'Cancelar')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (3, N'Alta')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (4, N'Baja')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (5, N'Modificar')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (6, N'Buscar')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (7, N'Usuario')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (8, N'Contraseña')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (9, N'Pregunta Secreta')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (10, N'Respuesta Secreta')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (11, N'Cambiar Contraseña')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (12, N'Cerrar Sesion')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (13, N'Gestion de Usuarios')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (14, N'Gestion de Bitacora')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (15, N'Gestion de Permisos')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (16, N'Gestion de Idiomas')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (17, N'Gestion de Backup')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (18, N'Cambiar Idioma')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (19, N'Alta de Idioma')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (20, N'Gestion de Infra')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (21, N'Gestion de Ventas')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (22, N'Gestion de personal')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (23, N'Servicios')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (24, N'Gestion de Alumnos')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (25, N'Gestion Intitucional')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1018, N'Ver todos')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1019, N'Ver por usuario')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1020, N'Ver por evento')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1021, N'Gestion intitucional')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1022, N'Recuperar Backup')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1023, N'Crear Backup')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1024, N'Nombre del Archivo')
SET IDENTITY_INSERT [dbo].[Palabra] OFF
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [DigitoVerificadorH], [ID_Tipo_Persona]) VALUES (1, N'Andres', N'Benitez', N'Oren', 30963708, N'Pendiente', 1)
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [DigitoVerificadorH], [ID_Tipo_Persona]) VALUES (2, N'Fulano', N'Detal', N'NingunLugar', 99999999, N'Pendiente', 1)
SET IDENTITY_INSERT [dbo].[Persona] OFF
SET IDENTITY_INSERT [dbo].[PreguntaSecreta] ON 

INSERT [dbo].[PreguntaSecreta] ([ID_PreguntaSecreta], [PreguntaSecreta], [DigitoVerificadorH]) VALUES (1, N'¿Cual fue la marca de tu primer auto?', N'cbd94268b1185051bc22578af2b18b87')
INSERT [dbo].[PreguntaSecreta] ([ID_PreguntaSecreta], [PreguntaSecreta], [DigitoVerificadorH]) VALUES (2, N'¿Cual es el nombre de tu primera mascota?', N'5f49a4f9bd59ed24a8ad776bc36b48d9')
SET IDENTITY_INSERT [dbo].[PreguntaSecreta] OFF
SET IDENTITY_INSERT [dbo].[RespuestasSecreta] ON 

INSERT [dbo].[RespuestasSecreta] ([ID_RespuestaSecreta], [ID_PreguntaSecreta], [ID_Usuario], [Respuesta], [DigitoVerificadorH]) VALUES (1, 1, 1, N'f6ae8cbc556ec608ef9dec3deab696be74c0c28f0c88602a3bd0618ad190958dcfa0860e83a4c3a763a7e62d825349f7', N'a0e3ff6bbe696e13fc5bb27c9a4fb8a4')
INSERT [dbo].[RespuestasSecreta] ([ID_RespuestaSecreta], [ID_PreguntaSecreta], [ID_Usuario], [Respuesta], [DigitoVerificadorH]) VALUES (2, 2, 1, N'ff29ef0ff17f4c41ca41a899d6c0a323f2895268f532ac960e1c36c60e3acfd8', N'a0e3ff6bbe696e13fc5bb27c9a4fb8a4')
SET IDENTITY_INSERT [dbo].[RespuestasSecreta] OFF
SET IDENTITY_INSERT [dbo].[TipoPersona] ON 

INSERT [dbo].[TipoPersona] ([ID_Tipo_Persona], [Descripcion]) VALUES (1, N'Personal no docente')
SET IDENTITY_INSERT [dbo].[TipoPersona] OFF
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1, N'Aceitar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1, N'Aceptar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 2, N'Cancelar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 3, N'Alta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 4, N'Baja')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 5, N'Modificar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 6, N'Buscar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 7, N'Usuario')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 8, N'Contraseña')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 9, N'Pregunta Secreta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 10, N'Respuesta Secreta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 11, N'Cambiar Contraseña')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 12, N'Cerrar Sesion')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 2, N'Cancelar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 3, N'Alta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 4, N'Baixa')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 5, N'Mudar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 6, N'Pesquisar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 7, N'Usuario')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 8, N'Contrasenha')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 9, N'Pergunta Secreita')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 10, N'Reposta Secreita')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 11, N'Mudar Contrasenha')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 12, N'Fechar Sesion')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1, N'Acept')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 2, N'Cancel')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 3, N'Create')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 4, N'Delete')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 5, N'Update')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 6, N'Search')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 7, N'User')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 8, N'Password')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 9, N'Secret Question')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 10, N'Secret Answer')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 11, N'Change Password')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 12, N'LogOut')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1, N'acceptar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 2, N'Cancel')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 3, N'Alta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 4, N'baixa')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 5, N'modificar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 6, N'Cercar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 7, N'Usuari')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 8, N'Clau Sesion')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 9, N'Pregunta Secreta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 10, N'Resposta Secreta')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 11, N'Canviar Contrasenya')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 12, N'Tancar')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 13, N'
Gestion de Usuarios')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 14, N'Gestion de Bitacora')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 15, N'Gestion de Permisos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 16, N'Gestion de Idiomas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 17, N'Gestion de Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 13, N'Gestão  de usuários')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 14, N'Gestão de logs')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 15, N'Gestão  de Permissões')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 16, N'Gestão da linguagem')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 17, N'Gestão  de backup
')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 13, N'User Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 14, N'Logs Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 15, N'Permissions Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 16, N'Language Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 17, N'Backup Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 13, N'Gestió d''Usuaris')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 14, N'Gestió de Bitacora')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 15, N'Gestió de Permisos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 16, N'Gestió d''Idiomes')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 17, N'Gestió de Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 18, N'Cambiar Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 19, N'Alta de Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 20, N'Gestion de Infra')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 21, N'Gestion de Ventas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 22, N'Gestion de personal')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 23, N'Servicios')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 24, N'Gestion de Alumnos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 18, N'Mudar idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 19, N'Alta de Linguagem ')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 20, N'Gestão de Infra ')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 21, N'Gestão de Vendas')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 22, N'Gestão de pessoal')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 23, N'Serviços')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 24, N'Gestão de Estudantes')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 18, N'Change language')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 19, N'New Language')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 20, N'Infra Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 21, N'Sales management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 22, N'Personnal management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 23, N'Services')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 24, N'Student Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 18, N'Canviar Idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 19, N'Alta d''idioma')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 20, N'Gestió de Infra')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 21, N'Gestió de Vendes')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 22, N'Gestió de personal')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 23, N'serveis')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 24, N'Gestió d''Alumnes')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 25, N'Gestion Intitucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 25, N'Gestão institucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 25, N'Institutional Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 25, N'Gestió Institucional')
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1018, N'Ver todos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1019, N'Ver por usuario')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1020, N'Ver por evento')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1018, N'Ver todos')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1019, N'Visualização por usuário')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1020, N'Visualização por evento')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1018, N'See all')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1019, N'View by user')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1020, N'View by event')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1018, N'veure tots')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1019, N'Veure per usuari')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1020, N'Veure per esdeveniment')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1021, N'Gestion Intitucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1021, N'Gestão institucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1021, N'Institutional Management')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1021, N'Gestió Institucional')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1022, N'Recuperar Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1023, N'Crear Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 1024, N'Nombre del Archivo')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1022, N'Recuperar backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1023, N'Criar backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (2, 1024, N'Nome do arquivo')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1022, N'Recovery Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1023, N'Create Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (3, 1024, N'File name')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1022, N'Recuperar Backup')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1023, N'Crear còpia de seguretat')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 1024, N'Nom de l''Arxiu')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1006, 1, N'Francecito')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1006, 1, N'Francecito')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1006, 1, N'Francecito')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1006, 1, N'Francecito')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1006, 1, N'Francecito')
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1006, 1, N'Francecito')
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Contraseña], [IntentosFallidos], [Logueado], [Legajo], [DigitoVerificadorH], [Bloqueado], [Habilitado]) VALUES (1, N'benitand', N'9565A66583CA72F6AAFB66DC768D8E4C0F3F2835DB99F9EFDA1578C64892CF2C', 0, 0, 1, N'f23fee533d52a50206b9b952368101f5', 0, 1)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Contraseña], [IntentosFallidos], [Logueado], [Legajo], [DigitoVerificadorH], [Bloqueado], [Habilitado]) VALUES (6, N'DetalFul', N'2BC805107667DB072DA4ADDD4085678CF44BDD36E12CB8B0A2B1A3CC04629F8D', 0, 0, 2, N'f46856f6cb7709e911f7fb14253db67d', 0, 1)
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Contraseña], [IntentosFallidos], [Logueado], [Legajo], [DigitoVerificadorH], [Bloqueado], [Habilitado]) VALUES (7, N'DetalFul', N'2BC805107667DB072DA4ADDD4085678CF44BDD36E12CB8B0A2B1A3CC04629F8D', 0, 0, 2, N'f46856f6cb7709e911f7fb14253db67d', 0, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_EventoBitacora] FOREIGN KEY([ID_Evento])
REFERENCES [dbo].[EventoBitacora] ([ID_Evento])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_EventoBitacora]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[CompositeFamilia]  WITH CHECK ADD  CONSTRAINT [FK_CompositeFamilia_Composite] FOREIGN KEY([ID_CompositeFamilia])
REFERENCES [dbo].[Composite] ([ID_Composite])
GO
ALTER TABLE [dbo].[CompositeFamilia] CHECK CONSTRAINT [FK_CompositeFamilia_Composite]
GO
ALTER TABLE [dbo].[CompositeFamilia]  WITH CHECK ADD  CONSTRAINT [FK_CompositeFamilia_Composite1] FOREIGN KEY([ID_CompositePatente])
REFERENCES [dbo].[Composite] ([ID_Composite])
GO
ALTER TABLE [dbo].[CompositeFamilia] CHECK CONSTRAINT [FK_CompositeFamilia_Composite1]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_TipoPersona] FOREIGN KEY([ID_Tipo_Persona])
REFERENCES [dbo].[TipoPersona] ([ID_Tipo_Persona])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_TipoPersona]
GO
ALTER TABLE [dbo].[RespuestasSecreta]  WITH CHECK ADD  CONSTRAINT [FK_RespuestasSecreta_PreguntaSecreta] FOREIGN KEY([ID_PreguntaSecreta])
REFERENCES [dbo].[PreguntaSecreta] ([ID_PreguntaSecreta])
GO
ALTER TABLE [dbo].[RespuestasSecreta] CHECK CONSTRAINT [FK_RespuestasSecreta_PreguntaSecreta]
GO
ALTER TABLE [dbo].[RespuestasSecreta]  WITH CHECK ADD  CONSTRAINT [FK_RespuestasSecreta_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[RespuestasSecreta] CHECK CONSTRAINT [FK_RespuestasSecreta_Usuario]
GO
ALTER TABLE [dbo].[TelefonoPersona]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoPersona_Persona] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[TelefonoPersona] CHECK CONSTRAINT [FK_TelefonoPersona_Persona]
GO
ALTER TABLE [dbo].[TelefonoPersona]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoPersona_Telefono] FOREIGN KEY([ID_Telefono])
REFERENCES [dbo].[Telefono] ([ID_Telefono])
GO
ALTER TABLE [dbo].[TelefonoPersona] CHECK CONSTRAINT [FK_TelefonoPersona_Telefono]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Palabra] FOREIGN KEY([ID_Palabra])
REFERENCES [dbo].[Palabra] ([ID_Palabra])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Palabra]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Persona1] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Persona1]
GO
ALTER TABLE [dbo].[UsuarioFamilia]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioFamilia_CompositeFamilia] FOREIGN KEY([ID_Permiso])
REFERENCES [dbo].[CompositeFamilia] ([ID_Permiso])
GO
ALTER TABLE [dbo].[UsuarioFamilia] CHECK CONSTRAINT [FK_UsuarioFamilia_CompositeFamilia]
GO
ALTER TABLE [dbo].[UsuarioFamilia]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioFamilia_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[UsuarioFamilia] CHECK CONSTRAINT [FK_UsuarioFamilia_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[dv_Bitacora]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dv_Bitacora]
@Fecha datetime
as
begin
begin tran Bitacora
begin try
select CAST(ID_Bitacora as nvarchar(max))+CAST(ID_Evento as nvarchar(max))+CAST(ID_Usuario as nvarchar(max))
+CAST(Fecha as nvarchar(max))+CAST(Descripcion as nvarchar(max))as digito from Bitacora where Fecha=@Fecha
commit tran Bitacora
end try
begin catch
rollback tran Bitacora
end catch
end


GO
/****** Object:  StoredProcedure [dbo].[dv_ModificarDVH]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[dv_ModificarDVH]
@Usuario nvarchar(50),
@DVH nvarchar(50)
as
begin
declare @legajo int
begin tran Modificar
begin try
select @legajo=Legajo from Usuario where NombreUsuario=@Usuario
update Usuario set DigitoVerificadorH=@DVH where NombreUsuario=@usuario and Legajo=@legajo
commit tran Modificar
end try

begin Catch
rollback tran Modificar
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[dv_Usuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[dv_Usuario]
@nombreUsuario nvarchar(50)
as
begin

declare @legajo int
begin tran Usuario
begin try
select @legajo=Legajo from usuario where NombreUsuario=@NombreUsuario
select  cast(ID_Usuario as nvarchar(max))+NombreUsuario +cast( Contraseña as nvarchar(max))+
cast(IntentosFallidos as nvarchar(max))+cast(Logueado as nvarchar(max))+cast(Legajo as nvarchar(max))+cast(Bloqueado as nvarchar(max)) as DGV
 from Usuario where NombreUsuario=NombreUsuario and Legajo=@legajo
 commit tran Usuario
 end try
 begin catch
 rollback tran Usuario
 end catch
end



GO
/****** Object:  StoredProcedure [dbo].[gb_AltaBitacora]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gb_AltaBitacora]
@NombreUsuario nvarchar(50),
@EventoBitacora nvarchar(50),
@Fecha datetime,
@Descripcion nvarchar(max)
as
begin
declare  @id_Usuario int ;
declare @ID_EventoBitacora as int

begin tran AltaBitacora
begin try
select @id_Usuario= ID_Usuario from Usuario where NombreUsuario=@NombreUsuario
select @ID_EventoBitacora=ID_Evento from EventoBitacora where Evento=@EventoBitacora
insert into Bitacora(ID_Usuario,ID_Evento,Fecha,descripcion)values(@ID_usuario,@ID_EventoBitacora,@Fecha,@Descripcion)
commit tran AltaBitacora
end try
begin catch
rollback tran AltaBitacora
end catch
end


GO
/****** Object:  StoredProcedure [dbo].[gb_ModificarDVH]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[gb_ModificarDVH]
@Fecha datetime,
@DVH nvarchar(50)
as
begin
begin tran ModificarDVH
begin try
update Bitacora set DigitoVerificadorH=@DVH where fecha=@Fecha

commit tran ModificarDVH
end try
begin catch
rollback tran ModificarDVH
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[gb_ObtenerDatosDVH]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gb_ObtenerDatosDVH]
@evento nvarchar(50),
@nombreUsuario nvarchar(50)

as
begin
declare @Id_Evento int;
declare @Id_Usuario int;
declare @Id_Bitacora int;
declare @Resultado table
(resultado nvarchar(10)
);
begin tran ObtenerDatosDVH
begin try 
select @Id_Evento=ID_Evento from EventoBitacora where Evento=@evento
select @Id_Usuario= ID_Usuario from Usuario where NombreUsuario=@nombreUsuario
select @Id_Bitacora=max(ID_Bitacora)+1 from Bitacora
insert into @Resultado(resultado)values(convert(nvarchar(10),@Id_Bitacora)+convert(nvarchar(10),@Id_Evento)+ CONVERT
(nvarchar(10),@Id_Usuario))
select * from @Resultado

commit tran ObtenerDatosDVH

end try

begin catch
rollback tran ObtenerDatosDVH
end catch

end



GO
/****** Object:  StoredProcedure [dbo].[gb_VerBitacoraCompleto]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gb_VerBitacoraCompleto]
as
begin
begin tran VerBitacoraCompleto
begin try
select p.Legajo,p.Nombre,p.Apellido,u.NombreUsuario,eb.Evento,b.Fecha,b.descripcion,b.DigitoVerificadorH from Bitacora as b 
join Usuario as u on b.ID_Usuario=u.ID_Usuario join Persona as p on u.ID_Usuario=b.ID_Usuario
join EventoBitacora as eb on eb.ID_Evento=b.ID_Evento
commit tran VerBitacoraCompleto
end try
begin catch
rollback tran VerBitacoraCompleto
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[gb_VerBitacoraPorEvento]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gb_VerBitacoraPorEvento]
@Evento nvarchar(50)
as
begin

begin tran VerBitacoraPorEvento
begin try
select p.Legajo,p.Nombre,p.Apellido,u.NombreUsuario,eb.Evento,b.Fecha,b.descripcion,b.DigitoVerificadorH from Bitacora as b 
join Usuario as u on b.ID_Usuario=u.ID_Usuario join Persona as p on u.ID_Usuario=b.ID_Usuario
join EventoBitacora as eb on eb.ID_Evento=b.ID_Evento where eb.Evento=@Evento
commit tran VerBitacoraPorEvento
end try
begin catch
rollback tran VerBitacoraPorEvento
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[gb_VerBitacoraPorUsuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gb_VerBitacoraPorUsuario]
@NombreUsuario nvarchar(50)
as
begin
DECLARE @legajo int
begin tran VerBitacoraPorUsuario
begin try
select @legajo=Legajo from Usuario where NombreUsuario=@nombreUsuario
select p.Legajo,p.Nombre,p.Apellido,u.NombreUsuario,eb.Evento,b.Fecha,b.descripcion,b.DigitoVerificadorH from Bitacora as b 
join Usuario as u on b.ID_Usuario=u.ID_Usuario join Persona as p on u.ID_Usuario=b.ID_Usuario
join EventoBitacora as eb on eb.ID_Evento=b.ID_Evento where u.NombreUsuario=@NombreUsuario and p.Legajo=@legajo
commit tran VerBitacoraPorUsuario
end try
begin catch
rollback tran VerBitacoraPorUsuario
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[gb_VerEventoBitacora]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gb_VerEventoBitacora]
as
begin
begin tran VerEventoBitacora
begin try
select ID_Evento,Evento from EventoBitacora
commit tran VerEventoBitacora
end try
begin catch
rollback tran VerEventoBitacora
end catch
end


GO
/****** Object:  StoredProcedure [dbo].[gu_AltaUsuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gu_AltaUsuario]
@NombreUsuario nvarchar(50),
@Contraseña nvarchar(max),
@Legajo integer

as
begin
begin tran AltaUsuario
begin try
insert into Usuario(NombreUsuario,Contraseña,IntentosFallidos,Logueado,Legajo,DigitoVerificadorH,Bloqueado,habilitado)values
(@NombreUsuario,@Contraseña,0,0,@Legajo,'',0,1)
commit tran AltaUsuario
end try
begin catch
rollback tran AltaUsuario
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[gu_EliminarUsuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gu_EliminarUsuario]
@nombreUsuario nvarchar(50)

as
begin
declare @legajo int
begin tran EliminarUsuarios
begin try
select @legajo=Legajo from Usuario where NombreUsuario=@nombreUsuario
update Usuario set habilitado=0 where NombreUsuario=@nombreUsuario and Legajo=@legajo
commit tran EliminarUsuarios
end try
begin catch
rollback tran EliminarUsuarios
end catch
end




GO
/****** Object:  StoredProcedure [dbo].[gu_ListarUsuarios]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gu_ListarUsuarios]
as
begin
begin tran ListarUsuarios
begin try
select NombreUsuario from Usuario where habilitado=1
commit tran ListarUsuarios
end try
begin catch
rollback tran ListarUsuarios
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[gu_ModificarUsuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[gu_ModificarUsuario]
@nombreUsuario nvarchar(50),
@contraseña nvarchar(max)
as
begin
declare @legajo int
begin tran ModificarUsuario
begin try
select @legajo=Legajo from Usuario where NombreUsuario=@nombreUsuario
update Usuario set Contraseña=@contraseña where NombreUsuario=@nombreUsuario and Legajo=Legajo
commit tran ModificarUsuario
end try
begin catch
rollback tran ModificarUsuario
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[id_CrearIdioma]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[id_CrearIdioma] 
@Idioma nvarchar(50)
as
begin

begin tran creraIdioma
begin try
insert into Idioma(Idioma) values(@Idioma)
commit tran crearIdioma
end try
begin catch
rollback tran crearIdioma
end catch

end
GO
/****** Object:  StoredProcedure [dbo].[p_ListarIdioma]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_ListarIdioma]
as
begin
begin tran ListarIdioma
begin try
select Idioma from idioma
commit tran ListarIdioma
end try
begin catch
rollback tran ListarIdioma
end catch
end



GO
/****** Object:  StoredProcedure [dbo].[p_ListarPalabrasPorIdioma]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_ListarPalabrasPorIdioma]
@Idioma nvarchar(50)
as 
begin
begin tran ListarPalabrasPorIdioma
begin try
select p.Palabra as tag,t.Palabra as traduccion from Palabra as p join Traduccion as t on p.ID_Palabra=t.ID_Palabra 
join Idioma as i on t.ID_Idioma=i.ID_Idioma where i.Idioma=@Idioma
commit tran ListarPalabrasPorIdioma
end try

begin catch
rollback tran ListarPalabrasPorIdioma
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[p_VerIdiomaUsuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_VerIdiomaUsuario]
@Usuario nvarchar (50)
as
begin
begin tran VerIdiomaUsuario
begin try
select i.Idioma from Usuario as u join Idioma as i on u.ID_Idioma=i.ID_Idioma WHERE NombreUsuario=@Usuario

commit tran VerIdiomaUsuario
end try

begin catch
rollback tran VerIdiomaUsuario
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarDigitoVerficadorV]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_BuscarDigitoVerficadorV]
@Tabla as nvarchar(50)
as
begin
set nocount on;
begin tran BuscarDigitoVerficadorV
begin try
select DigitoVerificadorH ,DigitoVerificadorV  from DigitoVerificadorVertical where NombreTabla=@Tabla
commit tran BuscarDigitoVerficadorV
end try
begin catch
rollback tran BuscarDigitoVerficadorV
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_VerPreguntasSecretas]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_VerPreguntasSecretas]
as
begin
set nocount on;
begin tran VerPreguntasSecretas
begin try
select PreguntaSecreta.PreguntaSecreta as Pregunta, PreguntaSecreta.DigitoVerificadorH as DigitoVerificadorH from PreguntaSecreta
commit tran VerPreguntasSecretas
end try
begin catch
print 'Error'	
rollback tran VerPreguntasSecretas
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_VerRespuestaSecreta]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_VerRespuestaSecreta]
(@id_Usuario int)
as
begin
set nocount on;
begin tran VerRespuestaSecreta
begin try
select  ps.PreguntaSecreta as Pregunta,rs.Respuesta from RespuestasSecreta as rs inner join Usuario as u on rs.ID_Usuario=u.ID_Usuario inner join PreguntaSecreta as ps on rs.ID_PreguntaSecreta=ps.ID_PreguntaSecreta
where rs.ID_Usuario=@id_Usuario
commit tran VerRespuestaSecreta
end try
begin catch
print 'Error'
rollback tran  VerRespuestaSecreta
end catch
end


GO
/****** Object:  StoredProcedure [dbo].[sp_VerUsuario]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_VerUsuario]
(@nombreUsuario varchar(50))
as
begin
declare @legajo as int
set nocount on;
begin tran VerUsuario
begin try
select @legajo=Legajo from Usuario where NombreUsuario=@nombreUsuario
select p.Nombre,p.Apellido,u.NombreUsuario, u.Contraseña,u.Logueado,u.IntentosFallidos,u.bloqueado,u.DigitoVerificadorH  , habilitado
from Usuario as u  join Persona as p on u.Legajo=u.Legajo
where u.NombreUsuario=@nombreUsuario and p.Legajo=@legajo
commit tran VerUsuario
end try
begin catch 
rollback tran VerUsuario
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[tr_AgregarTraduccion]    Script Date: 20/9/2017 3:44:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tr_AgregarTraduccion] 
@Idioma nvarchar(50),
@Palabra nvarchar(50),
@traduccion nvarchar(50)

as
begin

begin tran creraIdioma
begin try
declare @idIdioma as int
declare @idPalabra as int
select @idIdioma=ID_Idioma from Idioma where Idioma=@Idioma
select @idPalabra=ID_Palabra from palabra where Palabra=@Palabra
insert into Traduccion(ID_Idioma,ID_Palabra,Palabra) values(@idIdioma,@idPalabra,@traduccion)
commit tran creraIdioma
end try
begin catch
rollback tran creraIdioma
end catch

end

GO
USE [master]
GO
ALTER DATABASE [JardinInfantes] SET  READ_WRITE 
GO
