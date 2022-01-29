using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videoteca.Entidade
{
    class ElencoSeries
    {
        [Key]
        public int ID_ELENCO { get; set; } = 0;

        [ForeignKey("Serie")]
        public int ID_SERIE { get; set; } = 0;

        [ForeignKey("Ator")]
        [MaxLength(50)]
        public string NOME_ATOR { get; set; } = String.Empty;

        public Series? Serie { get; set; } = null;

        public Atores? Ator { get; set; } = null;
    }
}
