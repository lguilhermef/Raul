USE Raul
GO

CREATE TABLE Rules (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcName nvarchar(100) NOT NULL,
	nvcDescription nvarchar(100) NOT NULL,
	numOfPreQualificationGames int NOT NULL,
	numRegularGames int,
	numOfQualificationGames int NOT NULL,
	pointsPerVictory int NOT NULL,
	valueForSeason int NOT NULL,
	nvcPotsId nvarchar(100) NOT NULL,
	csvAwardsId nvarchar(100) NOT NULL,
	);