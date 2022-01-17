using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteca.BLL
{
    class SerieBLL
    {
        private int _id_serie;

        private string _titulo_serie = "";

        private string _capitulo = "";

        private string _descricao = "";

        private int _temporada = 0;

        private int _episodio = 0;

        private string _genero = "";

        private string _pais = "";

        private int _ano = 0;

        private int _duracao = 0;

        private int _avaliacao = 0;

        private bool _assistido = false;

        public int ID_SERIE
        {
            get
            {
                return _id_serie;
            }

            set
            {
                _id_serie = value;
            }
        }
        public string TITULO_SERIE
        {
            get
            {
                return _titulo_serie;
            }

            set
            {
                _titulo_serie = value;
            }
        }

        public string CAPITULO
        {
            get
            {
                return _capitulo;
            }

            set
            {
                _capitulo = value;
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

        public int TEMPORADA
        {
            get
            {
                return _temporada;
            }

            set
            {
                _temporada = value;
            }
        }

        public int EPISODIO
        {
            get
            {
                return _episodio;
            }

            set
            {
                _episodio = value;
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

        public string[] validacao()
        {
            string[] arrayValidacao = new string[5];
            arrayValidacao[0] = "valido";
            if (TITULO_SERIE.Equals(""))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[1] = "TITULO_SERIE";
            }
            if (TEMPORADA == 0)
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[2] = "TEMPORADA";
            }
            if (EPISODIO == 0)
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[3] = "EPISODIO";
            }
            if (GENERO.Equals("Gênero"))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[4] = "GENERO";
            }
            return arrayValidacao;
        }
    }
}
