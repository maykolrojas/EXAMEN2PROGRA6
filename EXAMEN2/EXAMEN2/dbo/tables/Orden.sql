CREATE TABLE [db].[Orden]
(
	[IdOrden] INT NOT NULL IDENTITY (1,1) CONSTRAINT PK_Orden PRIMARY KEY CLUSTERED (IdOrden)
   ,  IdProducto INT NOT NULL
      CONSTRAINT FK_IdProducto FOREIGN KEY(IdProducto) references db.Producto(IdProducto)
   , Estado varchar (50) not null
   ,  CantidadProducto INT NOT NULL
)
WITH (DATA_COMPRESSION= PAGE)
GO



