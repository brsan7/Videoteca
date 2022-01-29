using System.ComponentModel.DataAnnotations;

namespace Videoteca.Entidade
{
    class Atores
    {
        [Key]
        [MaxLength(50)]
        public string NOME_ATOR { get; set; } = String.Empty;

        public int IDADE { get; set; }

        [MaxLength(20)]
        public string PAIS { get; set; } = String.Empty;

        public bool APOSENTADO { get; set; }
    }
}
