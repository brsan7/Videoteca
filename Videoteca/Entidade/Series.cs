using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.Entidade
{
    class Series
    {
        [Key]
        public int ID_SERIE { get; set; } = 0;

        [MaxLength(50)]
        public string TITULO_SERIE { get; set; } = String.Empty;

        [MaxLength(50)]
        public string CAPITULO { get; set; } = String.Empty;

        [MaxLength(400)]
        public string? DESCRICAO { get; set; }

        public int TEMPORADA { get; set; }

        public int EPISODIO { get; set; }

        [MaxLength(50)]
        public string GENERO { get; set; } = String.Empty;

        [MaxLength(20)]
        public string? PAIS { get; set; }

        public int ANO { get; set; }

        public int DURACAO { get; set; }

        public int AVALIACAO { get; set; }

        public bool ASSISTIDO { get; set; }
    }
}
