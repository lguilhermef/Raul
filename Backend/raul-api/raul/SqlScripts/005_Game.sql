USE Raul
GO

CREATE TABLE Game (

	competition_name int NOT NULL, 
	competition_edition int NOT NULL,
	home_raul_user_id int NOT NULL,
	home_team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	home_score  int,
	away_raul_user_id int NOT NULL FOREIGN KEY REFERENCES RaulUser(id),
	away_team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	away_score  int,
	is_over bit NOT NULL,
	FOREIGN KEY (competition_name, competition_edition) REFERENCES Competition(oficial_name, edition)
	);