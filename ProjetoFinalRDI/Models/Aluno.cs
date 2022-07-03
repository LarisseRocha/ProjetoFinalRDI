using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjetoFinalRDI.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Column("nome")]

        public string Nome { get; set; }
        [Column("dataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("sexo")]
        public char Sexo { get; set; }

        [Column("totalFaltas")]
        public int TotalFaltas { get; set; }
        [Required]
        public int TurmaId { get; set; }

        #region Navigation Properties
        [JsonIgnore]
        public virtual Turma? Turma { get; set; }
        #endregion
    }
}
