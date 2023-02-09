using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    [Table("tb_Aluno")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeAluno { get; set; }

        public string EmailAluno { get; set; }

        public string Sexo { get; set; }

        public Login Login { get; set; }

        [ForeignKey("Login")]
        public int Id_login { get; set; }

        public Aluno()
        {

        }

        public Aluno(int Id, string Nome, string Email, string Sexo)
        {
            this.Id = Id;
            this.NomeAluno = Nome;
            this.EmailAluno = Email;
            this.Sexo = Sexo;
        }

        public override string ToString()
        {
            return Id + "," + NomeAluno + "," + EmailAluno + "," + Sexo;
        }
    }
}
