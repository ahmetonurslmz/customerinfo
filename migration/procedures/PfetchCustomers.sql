CREATE PROCEDURE [dbo].[PfetchCustomers]
AS
	SELECT customer_id, customer_name, customer_family_name, job_name, customer_salary, city_name
	FROM [dbo].[customers]
	INNER JOIN [dbo].[cities]
	ON [dbo].[customers].customer_city_id = [dbo].[cities].city_id
	INNER JOIN [dbo].[jobs]
	ON [dbo].[customers].customer_job_id = [dbo].[jobs].job_id
RETURN 0