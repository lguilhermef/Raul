USE Raul
GO

CREATE TABLE RaulUSer (

	username nvarchar(100) PRIMARY KEY,
    rl_fav_team_id int FOREIGN KEY REFERENCES Team(official_name),
    pes_fav_team_id int FOREIGN KEY REFERENCES Team(official_name),
    rival_team_id int FOREIGN KEY REFERENCES Team(official_name),
    media_fav_team_id int FOREIGN KEY REFERENCES Team(official_name),
    media_rival_team_id int FOREIGN KEY REFERENCES Team(official_name),
    fav_player_id int FOREIGN KEY REFERENCES Player(full_name)
	);