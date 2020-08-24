USE Raul
GO

CREATE TABLE Pot (

	pot_name nvarchar(100),
	universe_id int FOREIGN KEY REFERENCES Universe(id),
	pot_description nvarchar(100),
	media_description nvarchar(100),
	is_official_pot bit
	PRIMARY KEY (pot_name, universe_id)
	);