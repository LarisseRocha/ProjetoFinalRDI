using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjetoFinalRDI.Models
{
    public class Turma
    {
        public int Id { get; set; }
        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("ativo")]
        public bool Ativo { get; set; }
        [JsonIgnore]
        public virtual List<Aluno>? Aluno { get;  set; }
    }
}
