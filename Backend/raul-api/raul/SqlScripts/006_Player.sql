USE Raul
GO

CREATE TABLE Player (
	
	id int NOT NULL IDENTITY PRIMARY KEY,
	full_name nvarchar(100),
	team_id nvarchar(100) FOREIGN KEY REFERENCES Team(official_name)
	);