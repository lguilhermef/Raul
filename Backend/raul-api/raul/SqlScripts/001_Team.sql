USE Raul
GO

CREATE TABLE Team (

	official_name nvarchar(100) PRIMARY KEY,
	alias nvarchar(100) NOT NULL UNIQUE,
	initials nvarchar(10) NOT NULL UNIQUE,
	is_national_team bit NOT NULL
	);