USE Raul
GO

CREATE TABLE RaulUSer (

	nvcUsername nvarchar(100) PRIMARY KEY,
    rlFavteamId int FOREIGN KEY REFERENCES Team(id),
    favTeamId int FOREIGN KEY REFERENCES Team(id),
    rivalTeamId int FOREIGN KEY REFERENCES Team(id),
    mediaFavTeamId int FOREIGN KEY REFERENCES Team(id),
    mediaRivalTeamId int FOREIGN KEY REFERENCES Team(id),
    rlFavPlayerId int FOREIGN KEY REFERENCES Player(id)
	);