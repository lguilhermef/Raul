USE Raul
GO

CREATE TABLE Universe (

	id int NOT NULL IDENTITY PRIMARY KEY,
	alias nvarchar (100),
	history nvarchar (max),
	creation_date date
	);