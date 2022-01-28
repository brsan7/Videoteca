using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.BLL
{
    class AtorBLL
    {
        [Key]
        [MaxLength(50)]
        public string NOME_ATOR { get; set; } = String.Empty;

        public int IDADE { get; set; }

        [MaxLength(20)]
        public string PAIS { get; set; } = String.Empty;

        public bool APOSENTADO { get; set; }





        //private int _idade = 0;

        //private string _pais = "";

        //private bool _aposentado = false;

        //public string NOME_ATOR
        //{
        //    get
        //    {
        //        return _nome_ator;
        //    }

        //    set
        //    {
        //        _nome_ator = value;
        //    }
        //}

        //public int IDADE
        //{
        //    get
        //    {
        //        return _idade;
        //    }

        //    set
        //    {
        //        _idade = value;
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

        //public bool APOSENTADO
        //{
        //    get
        //    {
        //        return _aposentado;
        //    }

        //    set
        //    {
        //        _aposentado = value;
        //    }
        //}

        public bool validacao()
        {
            bool valido = true;
            if (NOME_ATOR.Equals(""))
            {
                valido = false;
            }
            return valido;
        }
    }
}
