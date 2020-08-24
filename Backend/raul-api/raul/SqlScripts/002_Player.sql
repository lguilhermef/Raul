USE Raul
GO

CREATE TABLE Player (

	full_name nvarchar(100) PRIMARY KEY,
	team_id nvarchar(100) FOREIGN KEY REFERENCES Team(official_name)
	);