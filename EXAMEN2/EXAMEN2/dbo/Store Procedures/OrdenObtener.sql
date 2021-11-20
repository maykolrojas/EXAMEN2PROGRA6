CREATE PROCEDURE [db].[OrdenObtener]
	@IdOrden int

AS BEGIN 
SET NOCOUNT ON

	SELECT 
	E.IdProducto,
	E.NombreProducto,
	E.PrecioProducto
	


	FROM db.Producto E
	WHERE
	( @IdOrden IS NULL OR @IdOrden=@IdOrden)
 

 END