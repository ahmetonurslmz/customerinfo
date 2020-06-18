CREATE PROCEDURE [dbo].[PfetchCustomersByjob]
	@customerJobId INT
AS
	SELECT * FROM [dbo].[customers] where customer_job_id = @customerJobId
RETURN 0