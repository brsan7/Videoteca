﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteca.BLL
{
    class FilmeBLL
    {
        private int _id_filme;

        private string _titulo_filme = "Desconhecido";

        private string _descricao = "Desconhecido";

        private string _genero = "Desconhecido";

        private string _pais = "Desconhecido";

        private int _ano = 0;

        private int _duracao = 0;

        private int _avaliacao = 0;

        private bool _assistido = false;

        public int ID_FILME
        {
            get
            {
                return _id_filme;
            }

            set
            {
                _id_filme = value;
            }
        }

        public string TITULO_FILME
        {
            get
            {
                return _titulo_filme;
            }

            set
            {
                _titulo_filme = value;
            }
        }

        public string DESCRICAO
        {
            get
            {
                return _descricao;
            }

            set
            {
                _descricao = value;
            }
        }

        public string GENERO
        {
            get
            {
                return _genero;
            }

            set
            {
                _genero = value;
            }
        }

        public string PAIS
        {
            get
            {
                return _pais;
            }

            set
            {
                _pais = value;
            }
        }

        public int ANO
        {
            get
            {
                return _ano;
            }

            set
            {
                _ano = value;
            }
        }

        public int DURACAO
        {
            get
            {
                return _duracao;
            }

            set
            {
                _duracao = value;
            }
        }

        public int AVALIACAO
        {
            get
            {
                return _avaliacao;
            }

            set
            {
                _avaliacao = value;
            }
        }

        public bool ASSISTIDO
        {
            get
            {
                return _assistido;
            }

            set
            {
                _assistido = value;
            }
        }
    }
}
