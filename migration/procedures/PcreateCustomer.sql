CREATE PROCEDURE [dbo].[PcreateCustomer]
	@CustomerName nvarchar(50),
	@CustomerFamilyName nvarchar(50),
	@CustomerJob Int,
	@CustomerSalary Int,
	@CustomerCity Int
AS
	INSERT INTO [dbo].[customers] (customer_name, customer_family_name, customer_job_id, customer_salary, customer_city_id)
	VALUES (@CustomerName, @CustomerFamilyName, @CustomerJob, @CustomerSalary, @CustomerCity)
RETURN 0
