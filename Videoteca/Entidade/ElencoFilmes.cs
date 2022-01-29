using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.Entidade
{
    class ElencoFilmes
    {
        [Key]
        public int ID_ELENCO { get; set; } = 0;

        [ForeignKey("Filme")]
        public int ID_FILME { get; set; } = 0;

        [ForeignKey("Ator")]
        [MaxLength(50)]
        public string NOME_ATOR { get; set; } = String.Empty;

        public Filmes? Filme { get; set; } = null;

        public Atores? Ator { get; set; } = null;
    }
}
