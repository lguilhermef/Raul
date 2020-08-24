USE Raul
GO

CREATE TABLE Competition (

	universe_id int NOT NULL FOREIGN KEY REFERENCES Universe(id),
	compt_name nvarchar(100) NOT NULL,
	alias nvarchar(100),
	history nvarchar(max),
	rules nvarchar (max),
	winner_id int FOREIGN KEY REFERENCES RaulUser(username),
	edition int NOT NULL,
	is_official_competition bit NOT NULL,
	PRIMARY KEY (universe_id, compt_name, edition)
	);