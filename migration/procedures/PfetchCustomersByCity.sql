CREATE PROCEDURE [dbo].[PfetchCustomersByCity]
	@customerCityId INT
AS
	SELECT * FROM [dbo].[customers] where customer_city_id = @customerCityId
RETURN 0