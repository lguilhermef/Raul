USE Raul
GO

CREATE TABLE Goal (

	id int NOT NULL IDENTITY PRIMARY KEY,
	raulUserId int NOT NULL FOREIGN KEY REFERENCES RaulUser(id),
	teamId int NOT NULL FOREIGN KEY REFERENCES Team(id),
	scorerId int NOT NULL FOREIGN KEY REFERENCES Player(id),
	assisId int NOT NULL FOREIGN KEY REFERENCES Player(id),
	gameId int NOT NULL FOREIGN KEY REFERENCES Game(id),
	intGamePart int NOT NULL,
	intGoalTime int NOT NULL
	);