CREATE TABLE [dbo].[ProductoXCategoria]
(
	[IdProductoXCategoria] BIGINT NOT NULL IDENTITY , 
    [IdProducto] BIGINT NOT NULL, 
    [IdCategoria] INT NOT NULL, 
    CONSTRAINT [PK_ProductoXCategoria] PRIMARY KEY NONCLUSTERED ([IdProductoXCategoria]), 
	CONSTRAINT [FK_ProductoXCategoria_Producto] FOREIGN KEY (IdProducto) REFERENCES [Producto]([Nombre]), 
    CONSTRAINT [FK_IdProducto] FOREIGN KEY (IdProducto) REFERENCES [Producto](Id) 
)
