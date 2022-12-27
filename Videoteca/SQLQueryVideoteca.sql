
-------------------------------Registro Atores Teste--------------------------------------
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Bruno Gagliasso',0,'Brasil',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Regiane Alves',0,'Brasil',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Jos� Wilker',0,'Brasil',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Chadwick Boseman',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Michael B. Jordan',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Lupita Nyong',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Delroy Lindo',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('M�lanie Thierry',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Soo Go',0,'Cor�ia do Sul',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Kyung-Gu Sol',0,'Cor�ia do Sul',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Kang Hye-Jeong',0,'Cor�ia do Sul',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Sonequa Martin-Gren',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Doug Jones',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Michelle Yeoh',0,'Mal�sia',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Maxwell Jenkins',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Taylor Russell',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Mina Sundwall',0,'EUA',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Chow Yun-Fat',0,'China',0);
INSERT INTO Atores(NOME_ATOR,IDADE,PAIS,APOSENTADO) VALUES('Zhang Ziyi',0,'China',0);
-------------------------------Registro Atores Teste--------------------------------------


-------------------------------Registro Filmes Teste--------------------------------------
INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Isolados','desconhecida','Suspense','Brasil',2014,85,7,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Pantera Negra','desconhecida','A��o','EUA',2018,125,10,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Destacamento Blood','desconhecida','Drama','EUA',2020,155,8,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Sonhos L�cidos','desconhecida','Fic��o Cient�fica','Cor�ia do Sul',2017,101,7,1);

INSERT INTO Filmes(TITULO_FILME,DESCRICAO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('O Tigre e o Drag�o','desconhecida','A��o','China',2000,120,10,1);
-------------------------------Registro Filmes Teste--------------------------------------


-------------------------------Registro Series Teste--------------------------------------
INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Star Trek - Discovery','O Ol� Vulcano','desconhecida',1,1,'Fic��o Cient�fica','EUA',2017,43,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Star Trek - Discovery','Batalha das Estrelas Bin�rias','desconhecida',1,2,'Fic��o Cient�fica','EUA',2017,39,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Star Trek - Discovery','Doce Tristeza - Parte 1','desconhecida',2,13,'Fic��o Cient�fica','EUA',2019,48,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Star Trek - Discovery','Doce Tristeza - Parte 2','desconhecida',2,14,'Fic��o Cient�fica','EUA',2019,65,10,1);

INSERT INTO Series(TITULO_SERIE,CAPITULO,DESCRICAO,TEMPORADA,EPISODIO,GENERO,PAIS,ANO,DURACAO,AVALIACAO,ASSISTIDO) 
			VALUES('Perdidos no Espa�o','Impacto','desconhecida',1,1,'Fic��o Cient�fica','EUA',2018,63,10,1);
-------------------------------Registro Series Teste--------------------------------------


-------------------------------Registro ElencoFilme Teste--------------------------------------
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(1,'Bruno Gagliasso');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(1,'Regiane Alves');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(1,'Jos� Wilker');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(2,'Chadwick Boseman');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(2,'Michael B. Jordan');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(2,'Lupita Nyong');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(3,'Chadwick Boseman');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(3,'Delroy Lindo');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(3,'M�lanie Thierry');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(4,'Soo Go');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(4,'Kyung-Gu Sol');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(4,'Kang Hye-Jeong');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Chow Yun-Fat');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Michelle Yeoh');
INSERT INTO ElencoFilmes(ID_FILME,NOME_ATOR) VALUES(5,'Zhang Ziyi');
-------------------------------Registro ElencoFilme Teste--------------------------------------


-------------------------------Registro ElencoSerie Teste--------------------------------------
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(1,'Sonequa Martin-Gren');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(1,'Doug Jones');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(1,'Michelle Yeoh');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(2,'Sonequa Martin-Gren');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(2,'Doug Jones');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(2,'Michelle Yeoh');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(3,'Sonequa Martin-Gren');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(3,'Doug Jones');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(3,'Michelle Yeoh');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(4,'Sonequa Martin-Gren');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(4,'Doug Jones');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(4,'Michelle Yeoh');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Maxwell Jenkins');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Taylor Russell');
INSERT INTO ElencoSeries(ID_SERIE,NOME_ATOR) VALUES(5,'Mina Sundwall');
-------------------------------Registro ElencoSerie Teste--------------------------------------
