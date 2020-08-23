USE Raul
GO

CREATE TABLE Player (

	nvcFullName nvarchar(100) PRIMARY KEY,
	teamId int FOREIGN KEY REFERENCES Team(id)
	);