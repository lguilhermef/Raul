USE Raul
GO

CREATE TABLE Team (

	nvcOfficialName nvarchar(100) PRIMARY KEY,
	nvcAlias nvarchar(100) NOT NULL UNIQUE,
	nvcInitials nvarchar(10) NOT NULL UNIQUE,
	bitNationalTeam bit NOT NULL
	);