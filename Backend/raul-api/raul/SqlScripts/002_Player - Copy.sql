USE Raul
GO

CREATE TABLE Player (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcFullName nvarchar(100) NOT NULL UNIQUE,
	teamId int FOREIGN KEY REFERENCES Team(id)
	);