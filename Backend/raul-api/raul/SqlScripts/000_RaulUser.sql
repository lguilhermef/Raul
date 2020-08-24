USE Raul
GO

CREATE TABLE RaulUser (

	username nvarchar(100) PRIMARY KEY,
    rl_fav_team nvarchar(100) FOREIGN KEY REFERENCES Team(team_name),
    pes_fav_team nvarchar(100) FOREIGN KEY REFERENCES Team(team_name),
    rival_team nvarchar(100) FOREIGN KEY REFERENCES Team(team_name),
    media_fav_team nvarchar(100) FOREIGN KEY REFERENCES Team(team_name),
    media_rival_team nvarchar(100) FOREIGN KEY REFERENCES Team(team_name),
    fav_player_id int FOREIGN KEY REFERENCES Player(id)
);