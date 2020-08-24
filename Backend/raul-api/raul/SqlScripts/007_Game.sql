USE Raul
GO

CREATE TABLE Game (

	id int NOT NULL IDENTITY PRIMARY KEY,
	competition_id int NOT NULL FOREIGN KEY REFERENCES Competition(id), 
	competition_round int NOT NULL,
	home_raul_user_id int NOT NULL,
	home_team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	home_score  int,
	away_raul_u_username int NOT NULL FOREIGN KEY REFERENCES RaulUser(username),
	away_team_id int NOT NULL FOREIGN KEY REFERENCES Team(id),
	away_score  int,
	is_over bit NOT NULL,
	played_date date,
	);