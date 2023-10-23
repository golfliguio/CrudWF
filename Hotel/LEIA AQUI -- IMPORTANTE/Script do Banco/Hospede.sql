USE [master]
GO

/****** Object:  Table [dbo].[Hospede]    Script Date: 24/11/2021 21:40:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hospede](
	[Codigo] [int] NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Telefone] [int] NULL,
	[Endereco] [nvarchar](50) NULL,
	[Dias] [int] NULL
) ON [PRIMARY]
GO

