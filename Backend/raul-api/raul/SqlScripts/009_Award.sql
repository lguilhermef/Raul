USE Raul
GO

CREATE TABLE Award (

	award_name nvarchar(100) PRIMARY KEY,
	official_description nvarchar(max),
	media_description nvarchar(max),
	winner_raul_u_username nvarchar (100) FOREIGN KEY REFERENCES RaulUser(username),
	is_official_award bit NOT NULL,
	);