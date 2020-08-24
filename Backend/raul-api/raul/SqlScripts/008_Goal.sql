USE Raul
GO

CREATE TABLE Goal (

	id int NOT NULL IDENTITY PRIMARY KEY,
	scorer_raul_u_username int NOT NULL FOREIGN KEY REFERENCES RaulUser(username),
	team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	scorer_id int NOT NULL FOREIGN KEY REFERENCES Player(id),
	assist_id int NOT NULL FOREIGN KEY REFERENCES Player(id),
	game_id int NOT NULL FOREIGN KEY REFERENCES Game(id),
	game_part int NOT NULL,
	goal_time int NOT NULL
	);