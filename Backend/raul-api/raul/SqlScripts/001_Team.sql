USE Raul
GO

CREATE TABLE Team (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcOfficialName nvarchar(100) NOT NULL UNIQUE,
	nvcAlias nvarchar(100) NOT NULL UNIQUE,
	nvcInitials nvarchar(10) NOT NULL UNIQUE,
	bitNationalTeam bit NOT NULL
	);