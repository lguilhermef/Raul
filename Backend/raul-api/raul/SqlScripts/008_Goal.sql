USE Raul
GO

CREATE TABLE Goal (

	id int NOT NULL IDENTITY PRIMARY KEY,
	scorer_raul_u_username nvarchar (100) NOT NULL FOREIGN KEY REFERENCES RaulUser(username),
	team nvarchar (100)  NOT NULL FOREIGN KEY REFERENCES Team(team_name),
	scorer_id int NOT NULL FOREIGN KEY REFERENCES Player(id),
	assist_id int NOT NULL FOREIGN KEY REFERENCES Player(id),
	game_id int NOT NULL FOREIGN KEY REFERENCES Game(id),
	game_part int NOT NULL,
	goal_time int NOT NULL
	);