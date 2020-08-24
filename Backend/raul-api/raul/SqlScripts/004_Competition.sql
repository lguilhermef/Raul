USE Raul
GO

CREATE TABLE Competition (

	oficial_name nvarchar(100) NOT NULL,
	alias nvarchar(100),
	history nvarchar(max),
	rules nvarchar (max),
	winner_id int FOREIGN KEY REFERENCES RaulUser(username),
	edition int NOT NULL
	PRIMARY KEY (oficial_name, edition)
	);