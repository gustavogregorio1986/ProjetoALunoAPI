using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    public class AvaliacaoDTO
    {
        
        public int Id { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public AlunoDTO AlunoDTO { get; set; }

        public int Id_ALuno { get; set; }

        public AvaliacaoDTO()
        {

        }

        public AvaliacaoDTO(int Id, double Nota1, double Nota2)
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
