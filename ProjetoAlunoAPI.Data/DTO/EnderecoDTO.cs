using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    
    public class EnderecoDTO
    {
        
        public int Id { get; set; }

        public string logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }


        public AlunoDTO AlunoDTO { get; set; }

       
        public int Id_Aluno { get; set; }

        public EnderecoDTO()
        {

        }

        public EnderecoDTO(int Id, string logradouro, string Bairro, string Cidade, string Uf)
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
