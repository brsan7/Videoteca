CREATE DATABASE Videoteca;
GO
USE Videoteca;

CREATE TABLE Filmes
(
	ID_FILME			INT IDENTITY NOT NULL,
	TITULO_FILME		VARCHAR(50) NOT NULL,
	DESCRICAO			VARCHAR(300),
	GENERO				VARCHAR(25) NOT NULL,
	PAIS				VARCHAR(25),
	ANO					INT,
	DURACAO				FLOAT,
	AVALIACAO			FLOAT,
	ASSISTIDO			BIT,
	Constraint PK_Filmes	Primary Key	(ID_FILME),
);

CREATE TABLE Series
(
	ID_SERIE				INT IDENTITY NOT NULL,
	TITULO_SERIE			VARCHAR(50) NOT NULL,
	CAPITULO				VARCHAR(50) NOT NULL,
	DESCRICAO				VARCHAR(300),
	TEMPORADA				INT,
	EPISODIO				INT,
	GENERO					VARCHAR(25) NOT NULL,
	PAIS					VARCHAR(25),
	ANO						INT,
	DURACAO					FLOAT,
	AVALIACAO				FLOAT,
	ASSISTIDO				BIT,
	CONSTRAINT PK_Series	PRIMARY KEY	(ID_SERIE)
);

CREATE TABLE Atores
(
	NOME_ATOR			VARCHAR(50) NOT NULL,
	IDADE				SMALLINT,
	PAIS				VARCHAR(25),
	APOSENTADO			BIT,
	CONSTRAINT PK_Atores	PRIMARY KEY	(NOME_ATOR)
);

CREATE TABLE ElencoFilme
(
	ID_ELENCO			INT IDENTITY NOT NULL,
	ID_FILME			INT NOT NULL,
	NOME_ATOR			VARCHAR(50) NOT NULL,
	CONSTRAINT PK_ElencoFilme	PRIMARY KEY	(ID_ELENCO),
	CONSTRAINT FK_ElencoFilme_Filmes FOREIGN KEY (ID_FILME)
	REFERENCES Filmes(ID_FILME),
	CONSTRAINT FK_ElencoFilme_Atores FOREIGN KEY (NOME_ATOR)
	REFERENCES Atores(NOME_ATOR)
);

CREATE TABLE ElencoSerie
(
	ID_ELENCO			INT IDENTITY NOT NULL,
	ID_SERIE			INT NOT NULL,
	NOME_ATOR			VARCHAR(50) NOT NULL,
	CONSTRAINT PK_ElencoSerie	PRIMARY KEY	(ID_ELENCO),
	CONSTRAINT FK_ElencoSerie_Series FOREIGN KEY (ID_SERIE)
	REFERENCES Series(ID_SERIE),
	CONSTRAINT FK_ElencoSerie_Atores FOREIGN KEY (NOME_ATOR)
	REFERENCES Atores(NOME_ATOR)
);

-------------------------------Registro Atores Teste--------------------------------------
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Will Smith',0,'USA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Angelina Jolie',0,'USA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Toni Ramos',0,'Brasil',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Regina Casé',0,'Brasil',0);
-------------------------------Registro Atores Teste--------------------------------------


-------------------------------Registro Filmes Teste--------------------------------------

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 1','desconhecida','Ação','Brasil',2022,7,10,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 2','desconhecida','Ficção Ciêntífica','Brasil',2022,7,10,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 3','desconhecida','Ficção Ciêntífica','Brasil',2022,7,10,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 4','desconhecida','Comédia','Brasil',2022,7,10,0);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 5','desconhecida','Comédia','Brasil',2022,7,10,0);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 6','desconhecida','Comédia','Brasil',2022,7,10,0);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Filme 7','desconhecida','Comédia','Brasil',2022,7,10,1);
-------------------------------Registro Filmes Teste--------------------------------------


-------------------------------Registro Series Teste--------------------------------------
INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 1','Capitulo 1','desconhecida',1,1,'Ação','Brasil',2022,7,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 1','Capitulo 2','desconhecida',1,2,'Ação','Brasil',2022,7,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 1','Capitulo 1','desconhecida',2,1,'Ação','Brasil',2022,7,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 1','Capitulo 2','desconhecida',2,2,'Ação','Brasil',2022,7,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 3','Capitulo 1','desconhecida',1,1,'Ação','Brasil',2022,7,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 3','Capitulo 2','desconhecida',1,2,'Ação','Brasil',2022,7,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Serie 3','Capitulo 3','desconhecida',1,3,'Ação','Brasil',2022,7,10,1);
-------------------------------Registro Series Teste--------------------------------------


-------------------------------Registro ElencoFilme Teste--------------------------------------
INSERT INTO ElencoFilme(ID_FILME,NOME_ATOR) VALUES(1,'Will Smith');
INSERT INTO ElencoFilme(ID_FILME,NOME_ATOR) VALUES(2,'Angelina Jolie');
INSERT INTO ElencoFilme(ID_FILME,NOME_ATOR) VALUES(3,'Toni Ramos');
INSERT INTO ElencoFilme(ID_FILME,NOME_ATOR) VALUES(4,'Regina Casé');
-------------------------------Registro ElencoFilme Teste--------------------------------------


-------------------------------Registro ElencoSerie Teste--------------------------------------
INSERT INTO ElencoSerie(ID_SERIE,NOME_ATOR) VALUES(1,'Will Smith');
INSERT INTO ElencoSerie(ID_SERIE,NOME_ATOR) VALUES(2,'Angelina Jolie');
INSERT INTO ElencoSerie(ID_SERIE,NOME_ATOR) VALUES(3,'Toni Ramos');
INSERT INTO ElencoSerie(ID_SERIE,NOME_ATOR) VALUES(4,'Regina Casé');
-------------------------------Registro ElencoSerie Teste--------------------------------------
