﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.BLL
{
    class FilmeBLL
    {
        [Key]
        public int ID_FILME { get; set; } = 0;

        [MaxLength(50)]
        public string TITULO_FILME { get; set; } = String.Empty;

        [MaxLength(300)]
        public string? DESCRICAO { get; set; }

        [MaxLength(25)]
        public string GENERO { get; set; } = String.Empty;

        [MaxLength(25)]
        public string PAIS { get; set; } = String.Empty;

        public int ANO { get; set; }

        public int DURACAO { get; set; }

        public int AVALIACAO { get; set; }

        public bool ASSISTIDO { get; set; }
        //private int _id_filme;

        //private string _titulo_filme = "";

        //private string _descricao = "";

        //private string _genero = "";

        //private string _pais = "";

        //private int _ano = 0;

        //private int _duracao = 0;

        //private int _avaliacao = 0;

        //private bool _assistido = false;

        //public int ID_FILME
        //{
        //    get
        //    {
        //        return _id_filme;
        //    }

        //    set
        //    {
        //        _id_filme = value;
        //    }
        //}

        //public string TITULO_FILME
        //{
        //    get
        //    {
        //        return _titulo_filme;
        //    }

        //    set
        //    {
        //        _titulo_filme = value;
        //    }
        //}

        //public string DESCRICAO
        //{
        //    get
        //    {
        //        return _descricao;
        //    }

        //    set
        //    {
        //        _descricao = value;
        //    }
        //}

        //public string GENERO
        //{
        //    get
        //    {
        //        return _genero;
        //    }

        //    set
        //    {
        //        _genero = value;
        //    }
        //}

        //public string PAIS
        //{
        //    get
        //    {
        //        return _pais;
        //    }

        //    set
        //    {
        //        _pais = value;
        //    }
        //}

        //public int ANO
        //{
        //    get
        //    {
        //        return _ano;
        //    }

        //    set
        //    {
        //        _ano = value;
        //    }
        //}

        //public int DURACAO
        //{
        //    get
        //    {
        //        return _duracao;
        //    }

        //    set
        //    {
        //        _duracao = value;
        //    }
        //}

        //public int AVALIACAO
        //{
        //    get
        //    {
        //        return _avaliacao;
        //    }

        //    set
        //    {
        //        _avaliacao = value;
        //    }
        //}

        //public bool ASSISTIDO
        //{
        //    get
        //    {
        //        return _assistido;
        //    }

        //    set
        //    {
        //        _assistido = value;
        //    }
        //}

        public string[] validacao()
        {
            string[] arrayValidacao = new string[3];
            arrayValidacao[0] = "valido";
            if (TITULO_FILME.Equals(""))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[1] = "TITULO_FILME";
            }
            if (GENERO.Equals("Gênero"))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[2] = "GENERO";
            }
            return arrayValidacao;
        }
    }
}
