CREATE TABLE [dbo].[ProductoCategoria] (
    [IdProductoCategoria] BIGINT IDENTITY (1, 1) NOT NULL,
    [IdProducto]          BIGINT NOT NULL,
    [IdCategoria]         INT    NOT NULL,
    CONSTRAINT [PK_ProductoCategoria] PRIMARY KEY CLUSTERED ([IdProductoCategoria] ASC),
    CONSTRAINT [FK_ProductoCategoria_ToTable] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Producto] ([Id]),
    CONSTRAINT [FK_ProductoCategoria_ToTable_1] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[Categoria] ([Id]),
    CONSTRAINT [AK_ProductoCategoria_Column] UNIQUE NONCLUSTERED ([IdProducto] ASC, [IdCategoria] ASC)
);

