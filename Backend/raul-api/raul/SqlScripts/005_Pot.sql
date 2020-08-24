USE Raul
GO

CREATE TABLE Pot (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcName nvarchar(100),
	nvcDescription nvarchar(100),
	nvcMediaDescription nvarchar(100),
	csvTeamId nvarchar(100)
	);