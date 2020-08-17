USE Raul
GO

CREATE TABLE Age (

	id int NOT NULL IDENTITY PRIMARY KEY,
	csvPesVersion nvarchar(100),
	nvcName nvarchar(100), --Alcunha nos Media
	nvcMediaDescription nvarchar(max), --História dos media
	csvSeason nvarchar(max),
	ballonDeOrWinnerId int FOREIGN KEY REFERENCES RaulUser(id)
	);