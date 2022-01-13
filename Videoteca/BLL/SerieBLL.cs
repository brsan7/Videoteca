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

        private string _titulo_serie = "Desconhecido";

        private string _capitulo = "Desconhecido";

        private string _descricao = "Desconhecido";

        private int _temporada = 0;

        private int _episodio = 0;

        private string _genero = "Desconhecido";

        private string _pais = "Desconhecido";

        private int _ano = 0;

        private double _duracao = 0;

        private double _avaliacao = 0;

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

        public double DURACAO
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

        public double AVALIACAO
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
