CREATE TABLE [dbo].[Producto] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Nombre]      NVARCHAR (100) NOT NULL,
    [Descripcion] NVARCHAR (500) NULL,
    [Precio]      DECIMAL (18)   CONSTRAINT [DF_Producto_Precio] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CK_Producto_Column] CHECK ([Precio]>(0)),
    CONSTRAINT [AK_Producto_Column] UNIQUE NONCLUSTERED ([Nombre] ASC)
);

