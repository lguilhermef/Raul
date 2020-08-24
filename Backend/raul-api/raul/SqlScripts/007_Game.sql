USE Raul
GO

CREATE TABLE Game (

	id int NOT NULL IDENTITY PRIMARY KEY,
	competition_id int NOT NULL, 
	home_raul_user_id int NOT NULL,
	home_team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	home_score  int,
	away_raul_user_id int NOT NULL FOREIGN KEY REFERENCES RaulUser(id),
	away_team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	away_score  int,
	is_over bit NOT NULL,
	played_date date,
	FOREIGN KEY (competition_id) REFERENCES Competition(id)
	);