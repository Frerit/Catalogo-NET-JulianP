CREATE TABLE [dbo].[Categoria] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (200) NOT NULL,
    [Estado]      BIT            CONSTRAINT [DF_Categoria_Estado] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED ([Id] ASC)
);

