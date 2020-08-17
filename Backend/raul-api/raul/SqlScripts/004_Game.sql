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

	-- Questão: é mais performante registar em cada jogo o resultado ou processar os dados relativos à tabela Golo, procurar todos
	-- id giauis ao deste jogo (goals com gameId = 3) e reconstruir o resultado? Isto é, vale mais poupar a Base de Dados e passar lá 
	-- menos tempo ou o tempo que gasto a processar os dados é tanto, ao fim de milhares de golos, que é melhor persistir os golos?