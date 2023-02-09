using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    [Table("tb_Turma")]
    public class Turma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeTurma { get; set; }

        public string Serie { get; set; }

        public Avaliacao Avaliacao { get; set; }

        [ForeignKey("Avaliacao")]
        public int Id_Avaliacao { get; set; }

        public Turma()
        {

        }

        public Turma(int Id, string NomeTurma, string Serie)
        {
            this.Id = Id;
            this.NomeTurma = NomeTurma;
            this.Serie = Serie;
        }

        public override string ToString()
        {
            return Id + "," + NomeTurma + "," + Serie;
        }
    }
}
