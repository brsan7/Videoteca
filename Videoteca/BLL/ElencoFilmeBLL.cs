using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.BLL
{
    class ElencoFilmeBLL
    {
        [Key]
        public int ID_ELENCO { get; set; } = 0;

        [ForeignKey("Filme")]
        public int ID_FILME { get; set; } = 0;

        [ForeignKey("Ator")]
        [MaxLength(50)]
        public string NOME_ATOR { get; set; } = String.Empty;

        public FilmeBLL? Filme { get; set; } = null;

        public AtorBLL? Ator { get; set; } = null;

        //private int _id_elenco;

        //private int _id_filme;

        //private string _nome_ator = "";

        //public int ID_ELENCO
        //{
        //    get
        //    {
        //        return _id_elenco;
        //    }

        //    set
        //    {
        //        _id_elenco = value;
        //    }
        //}

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

        public List<string> lstAtoresInserir(List<string> lstRegistrada, List<AtorBLL> lstAtualizada)
        {
            List<string> inserir = new List<string>();
            foreach (AtorBLL item in lstAtualizada)
            {
                if (!lstRegistrada.Contains(item.NOME_ATOR))
                {
                    inserir.Add(item.NOME_ATOR);
                }
            }
            return inserir;
        }

        public List<string> lstAtoresRemover(List<string> lstRegistrada, List<AtorBLL> lstAtualizada)
        {
            List<string> remover = new List<string>();
            bool contido = false;

            foreach (string ator_lstRegistrada in lstRegistrada)
            {
                foreach (AtorBLL item_lstAtualizada in lstAtualizada)
                {
                    if (item_lstAtualizada.NOME_ATOR.Equals(ator_lstRegistrada))
                    {
                        contido = true;
                    }
                }
                if (!contido)
                {
                    remover.Add(ator_lstRegistrada);
                }
                contido = false;
            }
            return remover;
        }
    }
}
