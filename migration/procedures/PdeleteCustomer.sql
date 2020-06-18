CREATE PROCEDURE [dbo].[PdeleteCustomer]
	@CustomerId int
AS
	DELETE [dbo].[customers] WHERE customer_id=@CustomerId
RETURN 0