USE Raul
GO

CREATE TABLE Team (

	team_name nvarchar(100) PRIMARY KEY,
	country nvarchar(50) FOREIGN KEY REFERENCES Country(country_name),
	alias nvarchar(100) NOT NULL UNIQUE,
	initials nvarchar(10) NOT NULL UNIQUE,
	is_national_team bit NOT NULL
	);