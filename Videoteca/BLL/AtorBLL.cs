using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteca.BLL
{
    class AtorBLL
    {
        private string _nome_ator;

        private int _idade = 0;

        private string _pais = "Desconhecido";

        private bool _aposentado = false;

        public string NOME_ATOR
        {
            get
            {
                return _nome_ator;
            }

            set
            {
                _nome_ator = value;
            }
        }

        public int IDADE
        {
            get
            {
                return _idade;
            }

            set
            {
                _idade = value;
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

        public bool APOSENTADO
        {
            get
            {
                return _aposentado;
            }

            set
            {
                _aposentado = value;
            }
        }
    }
}
