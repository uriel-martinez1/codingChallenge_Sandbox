use master
GO

-- Create the database
IF DB_ID('stored_procedure_practice') IS NOT NULL
BEGIN
	ALTER DATABASE stored_procedure_practice SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE stored_procedure_practice;
END

CREATE DATABASE stored_procedure_practice
GO

USE stored_procedure_practice
GO

BEGIN TRANSACTION;

CREATE TABLE customers
(
	customer_id INT IDENTITY(1,1) NOT NULL,
	customer_name VARCHAR(200) NOT NULL,
	contact_name VARCHAR(200) NOT NULL,
	address VARCHAR(100) NOT NULL,
	city VARCHAR(100) NOT NULL,
	postal_code VARCHAR(10) NOT NULL,
	country VARCHAR(60) NOT NULL,

	-- Primary Key
	CONSTRAINT PK_customers PRIMARY KEY (customer_id),
);

-- Adding values
INSERT INTO customers(customer_name, contact_name, address, city, postal_code, country)
VALUES ('Alfreds Futterkiste', 'Maria Anders', 'Obere Str. 57', 'Berlin', '12209', 'Germany'),
('Ana Trujillo Emparedados y helados', 'Ana Trujillo', 'Avda. de la Constitución 2222', 'México D.F.', '05021', 'Mexico'),
('Antonio Moreno Taquería', 'Antonio Moreno', 'Mataderos 2312', 'México D.F.', '05023', 'Mexico'),
('Around the Horn', 'Thomas Hardy', '120 Hanover Sq.', 'London', 'WA1 1DP', 'UK'),
('Berglunds snabbköp', 'Christina Berglund', 'Berguvsvägen 8', 'Luleå', 'S-958 22', 'Sweden')

COMMIT;