USE Raul
GO

CREATE TABLE Award (

	award_name nvarchar(100) PRIMARY KEY,
	official_description nvarchar(100),
	media_description nvarchar(100),
	winner_raul_u_username int FOREIGN KEY REFERENCES RaulUser(username),
	is_official_award bit NOT NULL,
	);