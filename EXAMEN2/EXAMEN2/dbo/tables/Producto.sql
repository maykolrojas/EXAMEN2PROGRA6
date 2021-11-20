CREATE TABLE [db].[Producto]
(
	[IdProducto] INT NOT NULL IDENTITY (1,1) CONSTRAINT PK_Producto PRIMARY KEY CLUSTERED (IdProducto)
   , NombreProducto varchar (50) not null
   ,  PrecioProducto INT NOT NULL
)
WITH (DATA_COMPRESSION= PAGE)
GO

