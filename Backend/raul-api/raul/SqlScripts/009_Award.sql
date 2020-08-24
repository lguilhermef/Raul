USE Raul
GO

CREATE TABLE Award (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcName nvarchar(100),
	nvcDescription nvarchar(100),
	nvcMediaDescription nvarchar(100),
	raulUserWinnerId int,
	);