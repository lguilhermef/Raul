USE Raul
GO

CREATE TABLE Game (

	id int NOT NULL IDENTITY PRIMARY KEY,
	pot_name nvarchar (100) NOT NULL,
	universe_id int NOT NULL,
	competition_name nvarchar(100) NOT NULL, 
	competition_edition int NOT NULL,
	competition_round int NOT NULL,
	home_raul_u_username nvarchar (100) FOREIGN KEY REFERENCES RaulUser(username) NOT NULL,
	home_team nvarchar (100) NOT NULL FOREIGN KEY REFERENCES Team(team_name),
	home_score  int,
	away_raul_u_username nvarchar (100) NOT NULL FOREIGN KEY REFERENCES RaulUser(username),
	away_team nvarchar (100) NOT NULL FOREIGN KEY REFERENCES Team(team_name),
	away_score  int,
	is_over bit NOT NULL,
	played_date date,
	FOREIGN KEY (universe_id, competition_name, competition_edition) REFERENCES Competition(universe_id, compt_name, edition),
	FOREIGN KEY (universe_id, pot_name) REFERENCES Pot(universe_id, pot_name)
	);