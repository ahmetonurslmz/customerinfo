CREATE PROCEDURE [dbo].[PupdateCustomer]
	@CustomerId int,
	@CustomerName nvarchar(50),
	@CustomerFamilyName nvarchar(50),
	@CustomerJob INT,
	@CustomerSalary INT,
	@CustomerCity INT
AS
	UPDATE [dbo].[customers] SET customer_name=@CustomerName, customer_family_name=@CustomerFamilyName, customer_city_id=@CustomerCity, customer_salary=@CustomerSalary, customer_job_id=@CustomerJob
	WHERE customer_id=@CustomerId
RETURN 0