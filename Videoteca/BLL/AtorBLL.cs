using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteca.BLL
{
    class AtorBLL
    {
        private string _NOME_ATOR;

        private short _IDADE;

        private string _PAIS;

        private short _ATIVO;

        public string NOME_ATOR
        {
            get
            {
                return _NOME_ATOR;
            }

            set
            {
                _NOME_ATOR = value;
            }
        }

        public short IDADE
        {
            get
            {
                return _IDADE;
            }

            set
            {
                _IDADE = value;
            }
        }

        public string PAIS
        {
            get
            {
                return _PAIS;
            }

            set
            {
                _PAIS = value;
            }
        }

        public short ATIVO
        {
            get
            {
                return _ATIVO;
            }

            set
            {
                _ATIVO = value;
            }
        }
    }
}
