CREATE PROCEDURE [db].[OrdenInsertar]
	@Estado varchar(50),
	@CantidadProducto int


AS BEGIN 
SET NOCOUNT ON
 
     BEGIN TRANSACTION TRASA

	BEGIN TRY

	insert into db.Orden
	(Estado,
	  CantidadProducto
	  )

	  VALUES
	  (

	@Estado,
	@CantidadProducto
	)

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