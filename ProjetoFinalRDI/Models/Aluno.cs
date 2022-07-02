using System.ComponentModel.DataAnnotations.Schema;

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
        public int TurmaId { get; set; }

        #region Navigation Properties
        public virtual Turma? Turma { get; set; }
        #endregion
    }
}
