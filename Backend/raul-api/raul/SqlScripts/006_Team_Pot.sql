USE Raul
GO

CREATE TABLE Team_Pot (

	universe_id int NOT NULL,
	pot_name nvarchar(100) NOT NULL,
	team_name nvarchar(100) FOREIGN KEY REFERENCES Team(team_name),
	FOREIGN KEY (pot_name, universe_id) REFERENCES Pot(pot_name, universe_id)
);