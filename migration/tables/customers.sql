CREATE TABLE [dbo].[customers] (
    [customer_id]                      INT           IDENTITY (1, 1) NOT NULL,
    [customer_name]             VARCHAR (50)  NOT NULL,
    [customer_family_name]                 VARCHAR (50)  NOT NULL,
    [customer_salary]          INT           NOT NULL,
    [customer_city_id]        INT           NOT NULL,
    [customer_job_id]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([customer_id] ASC),
    FOREIGN KEY ([customer_city_id]) REFERENCES [dbo].[cities] ([city_id]),
	FOREIGN KEY ([customer_job_id]) REFERENCES [dbo].[jobs] ([job_id])
);

