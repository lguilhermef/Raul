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

	-- Quest�o: � mais performante registar em cada jogo o resultado ou processar os dados relativos � tabela Golo, procurar todos
	-- id giauis ao deste jogo (goals com gameId = 3) e reconstruir o resultado? Isto �, vale mais poupar a Base de Dados e passar l� 
	-- menos tempo ou o tempo que gasto a processar os dados � tanto, ao fim de milhares de golos, que � melhor persistir os golos?