CREATE TABLE [dbo].[TabelMasini]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Marca] VARCHAR(50) NOT NULL, 
    [An] INT NOT NULL, 
    [Motor] INT NOT NULL, 
    [Caroserie] VARCHAR(50) NOT NULL, 
    [KM] INT NOT NULL, 
    [Pret] MONEY NOT NULL, 
    [Poza] IMAGE NOT NULL, 
    [Combustibil] VARCHAR(50) NOT NULL
)
