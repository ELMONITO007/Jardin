USE [master]
GO
/****** Object:  Database [JardinInfantes]    Script Date: 9/9/2017 2:45:40 a. m. ******/
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
ALTER DATABASE [JardinInfantes] SET AUTO_CLOSE OFF 
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
ALTER DATABASE [JardinInfantes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JardinInfantes] SET QUERY_STORE = OFF
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
/****** Object:  Table [dbo].[Backup]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Backup](
	[ID_Backup] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NULL,
	[TipoBackup] [nvarchar](50) NULL,
	[Fecha] [datetime] NULL,
	[Servidor] [nvarchar](50) NULL,
	[Path] [nvarchar](50) NULL,
 CONSTRAINT [PK_Backup] PRIMARY KEY CLUSTERED 
(
	[ID_Backup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DigitoVerificadorVertical]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[Palabra]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[Persona]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
	[ID_Idioma] [int] NULL,
	[ID_Tipo_Persona] [int] NULL,
 CONSTRAINT [PK_TelefonoPersona] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreguntaSecreta]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[RespuestasSecreta]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[Telefono]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[TelefonoPersona]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefonoPersona](
	[Legajo] [int] NULL,
	[ID_Telefono] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoPersona]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[Traduccion]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH]) VALUES (1, 1, 1, CAST(N'2017-08-27T00:00:00.000' AS DateTime), N'd46a029f2bc0709d3839dd775aa3d050')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH]) VALUES (2, 1, 1, CAST(N'2017-08-28T00:00:00.000' AS DateTime), N'c8baec4f56b0af43f99d0aa15daeedb5')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[EventoBitacora] ON 

INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (1, N'Alta usuario')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (1, N'Espaniol')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (2, N'Portugues')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (3, N'Ingles')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (4, N'Catalan')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (5, N'Guarani')
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
SET IDENTITY_INSERT [dbo].[Palabra] OFF
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Direccion], [DNI], [DigitoVerificadorH], [ID_Idioma], [ID_Tipo_Persona]) VALUES (1, N'Andres', N'Benitez', N'Oren', 30963708, N'Pendiente', 1, 1)
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
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (5, 1, N'Ne')
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
GO
INSERT [dbo].[Traduccion] ([ID_Idioma], [ID_Palabra], [Palabra]) VALUES (4, 25, N'Gestió Institucional')
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Contraseña], [IntentosFallidos], [Logueado], [Legajo], [DigitoVerificadorH], [Bloqueado]) VALUES (1, N'benitand', N'9565A66583CA72F6AAFB66DC768D8E4C0F3F2835DB99F9EFDA1578C64892CF2C', 0, 0, 1, N'f23fee533d52a50206b9b952368101f5', 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Backup]  WITH CHECK ADD  CONSTRAINT [FK_Backup_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Backup] CHECK CONSTRAINT [FK_Backup_Usuario]
GO
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
/****** Object:  StoredProcedure [dbo].[dv_ModificarDVH]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[dv_ModificarDVH]
@Usuario nvarchar(50),
@DVH nvarchar(50)
as
begin
begin tran Modificar
begin try

update Usuario set DigitoVerificadorH=@DVH where NombreUsuario=@usuario
commit tran Modificar
end try

begin Catch
rollback tran Modificar
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[dv_Usuario]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[dv_Usuario]
@nombreUsuario nvarchar(50)
as
begin
begin tran Usuario
begin try

select  cast(ID_Usuario as nvarchar(max))+NombreUsuario +cast( Contraseña as nvarchar(max))+
cast(IntentosFallidos as nvarchar(max))+cast(Logueado as nvarchar(max))+cast(Legajo as nvarchar(max))+cast(Bloqueado as nvarchar(max)) as DGV
 from Usuario where NombreUsuario=NombreUsuario
 commit tran Usuario
 end try
 begin catch
 rollback tran Usuario
 end catch
end



GO
/****** Object:  StoredProcedure [dbo].[id_CrearIdioma]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[p_AltaBitacora]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_AltaBitacora]
@ID_usuario int,
@ID_EventoBitacora int,
@Fecha datetime,
@DigitoH nvarchar(50)
as
begin
begin tran AltaBitacora
begin try
insert into Bitacora(ID_Usuario,ID_Evento,Fecha,DigitoVerificadorH)values(@ID_usuario,@ID_EventoBitacora,@Fecha,@DigitoH)
commit tran AltaBitacora
end try
begin catch
rollback tran AltaBitacora
end catch
end


GO
/****** Object:  StoredProcedure [dbo].[p_BuscarBitacoraPorEvento]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_BuscarBitacoraPorEvento]
@ID_Evento int
as
begin
begin tran BuscarBitacoraPorEvento
begin try
select u.NombreUsuario,eb.Evento,b.Fecha from EventoBitacora as eb join bitacora as b on eb.ID_Evento =b.ID_Evento join Usuario as u on b.ID_Usuario=u.ID_Usuario where b.ID_Bitacora=@ID_Evento 
commit tran BuscarBitacoraPorEvento
end try
begin catch
rollback tran BuscarBitacoraPorEvento
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[p_BuscarBitacoraPorUsuario]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_BuscarBitacoraPorUsuario]
@ID_usuario int
as
begin
begin tran BuscarBitacoraPorUsuario
begin try
select u.NombreUsuario,eb.Evento,b.Fecha from EventoBitacora as eb join bitacora as b on eb.ID_Evento =b.ID_Evento join Usuario as u on b.ID_Usuario=u.ID_Usuario where u.ID_Usuario=@ID_usuario
commit tran BuscarBitacoraPorUsuario
end try
begin catch
rollback tran BuscarBitacoraPorUsuario
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[p_ListarBitacora]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_ListarBitacora]
as
begin
begin tran ListarBitacora
begin try
select u.NombreUsuario,b.Fecha,eb.Evento from bitacora as b join usuario as u on u.ID_Usuario=b.ID_Usuario join EventoBitacora as eb on eb.ID_Evento=b.ID_Evento
commit tran ListarBitacora
end try
begin catch
rollback tran ListarBitacora
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[p_ListarIdioma]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[p_ListarPalabrasPorIdioma]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[p_VerEventoBitacora]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[p_VerEventoBitacora]
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
/****** Object:  StoredProcedure [dbo].[p_VerIdiomaUsuario]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_BuscarDigitoVerficadorV]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_VerPreguntasSecretas]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_VerRespuestaSecreta]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
/****** Object:  StoredProcedure [dbo].[sp_VerUsuario]    Script Date: 9/9/2017 2:45:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_VerUsuario]
(@nombreUsuario varchar(50))
as
begin
set nocount on;
begin tran VerUsuario
begin try
select p.Nombre,p.Apellido,u.NombreUsuario, u.Contraseña,u.Logueado,u.IntentosFallidos,u.bloqueado,u.DigitoVerificadorH  
from Usuario as u  join Persona as p on u.ID_Usuario=u.Legajo
where u.NombreUsuario=@nombreUsuario
commit tran VerUsuario
end try
begin catch 
rollback tran VerUsuario
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[tr_AgregarTraduccion]    Script Date: 9/9/2017 2:45:41 a. m. ******/
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
