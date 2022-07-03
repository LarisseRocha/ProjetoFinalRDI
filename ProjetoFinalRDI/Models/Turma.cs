using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjetoFinalRDI.Models
{
    public class Turma
    {
        public int Id { get; set; }
       
        [Column("nome")]
        public string Nome { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }
        [JsonIgnore]
        public virtual List<Aluno>? Aluno { get;  set; }
    }
}
