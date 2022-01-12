﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteca.BLL
{
    class ElencoFilmeBLL
    {
        private int _id_elenco;

        private int _id_filme;

        private string _nome_ator;

        public int ID_ELENCO
        {
            get
            {
                return _id_elenco;
            }

            set
            {
                _id_elenco = value;
            }
        }

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

        public List<string> lstAtoresInserir(List<string> lstRegistrada, List<string> lstAtualizada)
        {
            List<string> inserir = new List<string>();
            foreach(string ator in lstAtualizada)
            {
                if(!lstRegistrada.Contains(ator))
                {
                    inserir.Add(ator);
                }
            }
            return inserir;
        }

        public List<string> lstAtoresRemover(List<string> lstRegistrada, List<string> lstAtualizada)
        {
            List<string> remover = new List<string>();
            foreach (string ator in lstRegistrada)
            {
                if (!lstAtualizada.Contains(ator))
                {
                    remover.Add(ator);
                }
            }
            return remover;
        }
    }
}