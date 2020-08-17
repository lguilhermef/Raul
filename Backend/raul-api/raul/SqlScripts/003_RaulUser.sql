USE Raul
GO

CREATE TABLE RaulUSer (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcUsername nvarchar(100) NOT NULL UNIQUE,
    rlFavteamId int FOREIGN KEY REFERENCES Team(id),
    favTeamId int FOREIGN KEY REFERENCES Team(id),
    rivalTeamId int FOREIGN KEY REFERENCES Team(id),
    mediaFavTeamId int FOREIGN KEY REFERENCES Team(id),
    mediaRivalTeamId int FOREIGN KEY REFERENCES Team(id),
    rlFavPlayerId int FOREIGN KEY REFERENCES Player(id)
	);