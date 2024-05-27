--CREATION
USE master
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'WebsiteDb')
DROP DATABASE WebsiteDb
CREATE DATABASE WebsiteDb
USE WebsiteDb

-- Create the UserAccountAdd table
CREATE TABLE RegisterViewModel (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(256) NOT NULL,
    [Password] NVARCHAR(256) NOT NULL,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
Email NVARCHAR(256) NOT NULL,
    CONSTRAINT UC_Username UNIQUE (Username),
    CONSTRAINT UC_Email UNIQUE (Email)
);

--TABLE INSERTION
INSERT INTO RegisterViewModel(Username, [Password], FirstName, LastName)
VALUES ('Liam2505 ', 'Liam@2505', 'Liam', 'Paddyachee')

--DELETE FROM Users
--TABLE MANIPULATION
SELECT *
FROM RegisterViewModel


CREATE TABLE Products (
ProductId INT PRIMARY KEY IDENTITY,
ProductName NVARCHAR (256) NOT NULL,
ArtistName NVARCHAR (100) NOT NULL,
Price DECIMAL (10, 2) NOT NULL,
[Description] NVARCHAR (100) NOT NULL,
Category NVARCHAR (50) NOT NULL,
[Availability] BIT NOT NULL,

);
SELECT *
FROM Products

