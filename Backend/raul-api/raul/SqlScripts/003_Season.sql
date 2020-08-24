USE Raul
GO

CREATE TABLE Season (

	season_number int NOT NULL,
	age int NOT NULL,
	universe_id int NOT NULL ,
	pes_version int NOT NULL,
	season_history nvarchar(max),
	media_description nvarchar(max),
	player_of_the_year_id nvarchar (100) FOREIGN KEY REFERENCES RaulUser(username),
	FOREIGN KEY (age, universe_id) REFERENCES Age(age, universe_id),
	PRIMARY KEY (season_number, age)
	);