USE [PeliculasDB]
GO

/****** Object:  Table [dbo].[TBL_PELICULA_Old]    Script Date: 8/7/2020 6:44:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBL_PELICULA_Old](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](50) NULL,
	[Director] [varchar](50) NULL,
	[AutorPrincipal] [varchar](50) NULL,
	[NumAutor] [int] NULL,
	[Duracion] [float] NULL,
	[Estreno] [int] NULL,
 CONSTRAINT [PK_TBL_PELICULA] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


