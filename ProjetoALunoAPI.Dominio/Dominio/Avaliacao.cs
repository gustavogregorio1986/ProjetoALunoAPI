using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    [Table("tb_Avaliacao")]
    public class Avaliacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_ALuno { get; set; }

        public Avaliacao()
        {

        }

        public Avaliacao(int Id, double Nota1, double Nota2)
        {
            this.Id = Id;
            this.Nota1 = Nota1;
            this.Nota2 = Nota2;
        }

        public override string ToString()
        {
            return Id + "," + Nota1 + "," + Nota2;
        }
    }
}
