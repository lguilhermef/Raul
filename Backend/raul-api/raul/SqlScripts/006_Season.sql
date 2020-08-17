USE Raul
GO

CREATE TABLE Season (

	id int NOT NULL IDENTITY PRIMARY KEY,
	intYear int NOT NULL UNIQUE,
	intPesVersion int NOT NULL,
	nvcDescription nvarchar(max), --O que é uma Season?
	nvcMediaDescription nvarchar(max), --Como ficou conhecida nos Media?
	csvCompetition nvarchar(max),
	csvAward nvarchar(50),
	playerOfTheYearWinnerId int FOREIGN KEY REFERENCES RaulUser(id)
	);