USE Raul
GO

CREATE TABLE Universe (

	id int NOT NULL IDENTITY PRIMARY KEY,
	history nvarchar (max),
	creation_date date
	);