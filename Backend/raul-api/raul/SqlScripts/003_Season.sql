USE Raul
GO

CREATE TABLE Season (

	season_number int NOT NULL,
	age_id int NOT NULL FOREIGN KEY REFERENCES Age(id),
	pes_version int NOT NULL,
	season_history nvarchar(max),
	media_description nvarchar(max),
	player_of_the_year_id nvarchar (100) FOREIGN KEY REFERENCES RaulUser(username)
	PRIMARY KEY (season_number, age_id)
	);