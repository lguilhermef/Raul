USE Raul
GO

CREATE TABLE Competition (

	id int NOT NULL IDENTITY PRIMARY KEY,
	nvcName nvarchar(100),
	nvcDescription nvarchar(max),
	nvcRules nvarchar (max),
	csvGame nvarchar(max),
	csvAward nvarchar(50),
	winnerId int FOREIGN KEY REFERENCES RaulUser(id),
	);

	-- Questão: é mais performante registar em cada jogo o resultado ou processar os dados relativos à tabela Golo, procurar todos
	-- id giauis ao deste jogo (goals com gameId = 3) e reconstruir o resultado? Isto é, vale mais poupar a Base de Dados e passar lá 
	-- menos tempo ou o tempo que gasto a processar os dados é tanto, ao fim de milhares de golos, que é melhor persistir os golos?