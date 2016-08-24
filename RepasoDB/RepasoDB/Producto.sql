CREATE TABLE [dbo].[Producto]
(
	[Id] BIGINT NOT NULL IDENTITY, 
    [Nombre] NVARCHAR(100) NOT NULL, 
    [Descripcion] NVARCHAR(250) NOT NULL, 
    [Precio] DECIMAL NOT NULL, 
    CONSTRAINT [PK_Producto] PRIMARY KEY ([Id]), 
    CONSTRAINT [CK_Producto_Price] CHECK ([Precio] > 0), 
    CONSTRAINT [UQ_Producto_Nombre] UNIQUE ([Nombre])

	-- Publis Database

)
