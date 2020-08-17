USE Raul
GO

CREATE TABLE Game (

	id int NOT NULL IDENTITY PRIMARY KEY,
	homeRaulUserId int NOT NULL FOREIGN KEY REFERENCES RaulUser(id),
	homeTeamId int NOT NULL FOREIGN KEY REFERENCES Team(id),
	homeScore  int NOT NULL,
	awayRaulUserId int NOT NULL FOREIGN KEY REFERENCES RaulUser(id),
	awayTeamId int NOT NULL FOREIGN KEY REFERENCES Team(id),
	awayScore  int NOT NULL,
	isOver bit NOT NULL,
	);

	-- Quest�o: � mais performante registar em cada jogo o resultado ou processar os dados relativos � tabela Golo, procurar todos
	-- id giauis ao deste jogo (goals com gameId = 3) e reconstruir o resultado? Isto �, vale mais poupar a Base de Dados e passar l� 
	-- menos tempo ou o tempo que gasto a processar os dados � tanto, ao fim de milhares de golos, que � melhor persistir os golos?