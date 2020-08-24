USE Raul
GO

CREATE TABLE Season (

	id int NOT NULL IDENTITY PRIMARY KEY,
	age_id int NOT NULL FOREIGN KEY REFERENCES Age(id),
	season_number int NOT NULL UNIQUE,
	pes_version int NOT NULL,
	season_history nvarchar(max),
	media_description nvarchar(max),
	player_of_the_year_id nvarchar (100) FOREIGN KEY REFERENCES RaulUser(username)
	);