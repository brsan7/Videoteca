
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
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(1,'Will Smith');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(1,'Angelina Jolie');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(2,'Toni Ramos');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(2,'Regina Casé');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(3,'Will Smith');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(4,'Angelina Jolie');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(3,'Toni Ramos');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(4,'Regina Casé');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Will Smith');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Angelina Jolie');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Toni Ramos');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Regina Casé');
-------------------------------Registro ElencoFilme Teste--------------------------------------


-------------------------------Registro ElencoSerie Teste--------------------------------------
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(1,'Will Smith');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(1,'Angelina Jolie');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(2,'Toni Ramos');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(2,'Regina Casé');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(3,'Will Smith');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(4,'Angelina Jolie');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(3,'Toni Ramos');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(4,'Regina Casé');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Will Smith');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Angelina Jolie');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Toni Ramos');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Regina Casé');
-------------------------------Registro ElencoSerie Teste--------------------------------------
