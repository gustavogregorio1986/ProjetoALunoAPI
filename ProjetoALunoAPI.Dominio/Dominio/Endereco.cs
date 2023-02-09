using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    [Table("tb_Endereco")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }


        public Aluno Aluno { get; set; }

        [ForeignKey("Aluno")]
        public int Id_Aluno { get; set; }

        public Endereco()
        {

        }

        public Endereco(int Id, string logradouro, string Bairro, string Cidade, string Uf)
        {
            this.Id = Id;
            this.logradouro = logradouro;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Uf = Uf;
        }

        public override string ToString()
        {
            return Id + "," + logradouro + "," + Bairro + "," + Cidade + "," + Uf;
        }
    }
}
