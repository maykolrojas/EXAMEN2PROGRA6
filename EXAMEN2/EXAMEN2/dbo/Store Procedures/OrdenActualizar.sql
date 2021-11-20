CREATE PROCEDURE [db].[OrdenActualizar]
	 @IdOrden int, 
	@Estado varchar(50),
	@CantidadProducto int


AS BEGIN 
SET NOCOUNT ON
 
     BEGIN TRANSACTION TRASA

	BEGIN TRY

	UPDATE  db.Orden SET
	Estado=@Estado,
	CantidadProducto =@CantidadProducto

	COMMIT TRANSACTION TRASA

	SELECT 0 AS CodeError, '' AS MsgError
	END  TRY

	BEGIN CATCH

	SELECT 
	   ERROR_NUMBER() AS CodeError,
	   ERROR_MESSAGE() AS MsgError

	   ROLLBACK TRANSACTION TRASA

	   END CATCH 

	   END 