CREATE TABLE [dbo].[Livro]
(
	[Codigo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Titulo] NVARCHAR(50) NULL, 
    [Autor] NVARCHAR(50) NULL, 
    [Lancamento] NVARCHAR(50) NULL
)