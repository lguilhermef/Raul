USE Raul
GO

CREATE TABLE Universe_User (

	universe_id int NOT NULL FOREIGN KEY REFERENCES Universe(id),
	raul_username nvarchar (100) FOREIGN KEY REFERENCES RaulUser(username)
	)