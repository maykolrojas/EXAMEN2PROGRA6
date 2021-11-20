CREATE PROCEDURE [db].[ProductoObtener]
	@IdProducto int = null
	
AS BEGIN 
SET NOCOUNT ON

	SELECT 
	E.IdProducto,
	E.NombreProducto,
	E.PrecioProducto

	FROM db.Producto E
	WHERE
	( @IdProducto IS NULL OR IdProducto=@IdProducto)
 

 END
