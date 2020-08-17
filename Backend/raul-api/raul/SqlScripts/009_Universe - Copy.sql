USE Raul
GO

CREATE TABLE Universe (

	id int NOT NULL IDENTITY PRIMARY KEY,
	csvRaulUser nvarchar(50),
	csvAge nvarchar(200)
	);