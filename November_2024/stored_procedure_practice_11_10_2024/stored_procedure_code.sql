--USE stored_procedure_practice;
--GO

---- Drop the exisiting procedure if it exists
--IF OBJECT_ID('SelectAllCustomers', 'P') IS NOT NULL
--	DROP PROCEDURE SelectAllCustomers;

-- Format for stored procedure
CREATE PROCEDURE SelectAllCustomers_NoLoop
AS
BEGIN
	SELECT * FROM Customers
END;
GO

-- This actually executes the stored procedure
EXEC SelectAllCustomers_NoLoop;

SELECT name
FROM sys.procedures 
WHERE name = 'SelectAllCustomers_NoLoop';
