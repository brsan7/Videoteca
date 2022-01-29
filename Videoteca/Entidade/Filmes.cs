using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.Entidade
{
    class Filmes
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
    }
}
