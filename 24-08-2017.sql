USE [master]
GO
/****** Object:  Database [JardinInfantes]    Script Date: 27/08/2017 1:42:39 ******/
CREATE DATABASE [JardinInfantes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JardinInfantes', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.OKTUBRE\MSSQL\DATA\JardinInfantes.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JardinInfantes_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.OKTUBRE\MSSQL\DATA\JardinInfantes_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [JardinInfantes] SET AUTO_CREATE_STATISTICS ON 
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
/****** Object:  StoredProcedure [dbo].[p_AltaBitacora]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[p_BuscarBitacoraPorEvento]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[p_BuscarBitacoraPorUsuario]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[p_VerEventoBitacora]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_BuscarDigitoVerficadorV]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_VerIdiomas]    Script Date: 27/08/2017 1:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_VerIdiomas]
as
begin
set nocount on;
begin tran VerIdiomas
begin try
select Idioma.Idioma as Idioma from Idioma
commit tran VerIdiomas
end try
begin catch
print 'Error'	
rollback tran VerIdiomas
end catch
end

GO
/****** Object:  StoredProcedure [dbo].[sp_VerPreguntasSecretas]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_VerRespuestaSecreta]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_VerUsuario]    Script Date: 27/08/2017 1:42:40 ******/
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
select u.ID_Usuario,i.Idioma,u.NombreUsuario as Usuario, u.Contraseña,u.Logueado,u.IntentosFallidos,u.bloqueado,u.DigitoVerificadorH  from Usuario as u join Idioma as i on u.ID_Idioma=i.ID_Idioma
where u.NombreUsuario=@nombreUsuario
commit tran VerUsuario
end try
begin catch 
rollback tran VerUsuario
end catch
end
GO
/****** Object:  Table [dbo].[Backup]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[DigitoVerificadorVertical]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[Palabra]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[PreguntaSecreta]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[RespuestasSecreta]    Script Date: 27/08/2017 1:42:40 ******/
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
/****** Object:  Table [dbo].[Traduccion]    Script Date: 27/08/2017 1:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Traduccion] [int] IDENTITY(1,1) NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[ID_Palabra] [int] NOT NULL,
	[Palabra] [nvarchar](50) NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ID_Traduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/08/2017 1:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[ID_Idioma] [int] NOT NULL,
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

INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH]) VALUES (1, 1, 1, CAST(0x0000A7DC00000000 AS DateTime), N'd46a029f2bc0709d3839dd775aa3d050')
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Evento], [ID_Usuario], [Fecha], [DigitoVerificadorH]) VALUES (2, 1, 1, CAST(0x0000A7DD00000000 AS DateTime), N'c8baec4f56b0af43f99d0aa15daeedb5')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[EventoBitacora] ON 

INSERT [dbo].[EventoBitacora] ([ID_Evento], [Evento]) VALUES (1, N'Alta usuario')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (1, N'Espaniol')
INSERT [dbo].[Idioma] ([ID_Idioma], [Idioma]) VALUES (2, N'Portugues')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
SET IDENTITY_INSERT [dbo].[Palabra] ON 

INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (1, N'Aceptar')
INSERT [dbo].[Palabra] ([ID_Palabra], [Palabra]) VALUES (2, N'Cancelar')
SET IDENTITY_INSERT [dbo].[Palabra] OFF
SET IDENTITY_INSERT [dbo].[PreguntaSecreta] ON 

INSERT [dbo].[PreguntaSecreta] ([ID_PreguntaSecreta], [PreguntaSecreta], [DigitoVerificadorH]) VALUES (1, N'¿Cual fue la marca de tu primer auto?', N'cbd94268b1185051bc22578af2b18b87')
INSERT [dbo].[PreguntaSecreta] ([ID_PreguntaSecreta], [PreguntaSecreta], [DigitoVerificadorH]) VALUES (2, N'¿Cual es el nombre de tu primera mascota?', N'5f49a4f9bd59ed24a8ad776bc36b48d9')
SET IDENTITY_INSERT [dbo].[PreguntaSecreta] OFF
SET IDENTITY_INSERT [dbo].[RespuestasSecreta] ON 

INSERT [dbo].[RespuestasSecreta] ([ID_RespuestaSecreta], [ID_PreguntaSecreta], [ID_Usuario], [Respuesta], [DigitoVerificadorH]) VALUES (1, 1, 1, N'f6ae8cbc556ec608ef9dec3deab696be74c0c28f0c88602a3bd0618ad190958dcfa0860e83a4c3a763a7e62d825349f7', N'a0e3ff6bbe696e13fc5bb27c9a4fb8a4')
INSERT [dbo].[RespuestasSecreta] ([ID_RespuestaSecreta], [ID_PreguntaSecreta], [ID_Usuario], [Respuesta], [DigitoVerificadorH]) VALUES (2, 2, 1, N'ff29ef0ff17f4c41ca41a899d6c0a323f2895268f532ac960e1c36c60e3acfd8', N'a0e3ff6bbe696e13fc5bb27c9a4fb8a4')
SET IDENTITY_INSERT [dbo].[RespuestasSecreta] OFF
SET IDENTITY_INSERT [dbo].[Traduccion] ON 

INSERT [dbo].[Traduccion] ([ID_Traduccion], [ID_Idioma], [ID_Palabra], [Palabra]) VALUES (1, 2, 1, N'Aceitar')
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID_Usuario], [ID_Idioma], [NombreUsuario], [Contraseña], [IntentosFallidos], [Logueado], [Legajo], [DigitoVerificadorH], [Bloqueado]) VALUES (1, 1, N'benitand', N'E3B0C44298FC1C149AFBF4C8996FB92427AE41E4649B934CA495991B7852B855', 0, 0, 1, N'3cf242d785aa06a55b9a8079d517c23f', 0)
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
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
USE [master]
GO
ALTER DATABASE [JardinInfantes] SET  READ_WRITE 
GO
