USE [PeliculasDB]
GO

/****** Object:  Table [dbo].[TBL_PELICULA]    Script Date: 8/7/2020 5:53:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBL_PELICULA](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varbinary](50) NULL,
	[Director] [varbinary](50) NULL,
	[AutorPrincipal] [varbinary](50) NULL,
	[No_Autor] [int] NULL,
	[Duracion] [float] NULL,
	[Estreno] [int] NULL,
 CONSTRAINT [PK_TBL_PELICULA_1] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


