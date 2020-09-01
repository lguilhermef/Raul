USE Raul
GO

CREATE TABLE Universe_User (

	universe_id int NOT NULL FOREIGN KEY REFERENCES Universe(id),
	raul_username nvarchar (100) NOT NULL FOREIGN KEY REFERENCES RaulUser(username),
	PRIMARY KEY (universe_id, raul_username)
	);