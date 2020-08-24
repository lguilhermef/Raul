USE Raul
GO

CREATE TABLE Age (

	age int NOT NULL,
	universe_id int NOT NULL FOREIGN KEY REFERENCES Universe(id),
	pes_version nvarchar(100),
	media_name nvarchar(100),
	media_description nvarchar(max),
	ballon_de_or_winner_id int FOREIGN KEY REFERENCES RaulUser(username)
	PRIMARY KEY (age, universe_id)
	);