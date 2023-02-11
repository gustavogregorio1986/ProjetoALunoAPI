using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    
    public class TurmaDTO
    {
        
        public int Id { get; set; }

        public string NomeTurma { get; set; }

        public string Serie { get; set; }

        public AvaliacaoDTO AvaliacaoDTO { get; set; }

        
        public int Id_Avaliacao { get; set; }

        public TurmaDTO()
        {

        }

        public TurmaDTO(int Id, string NomeTurma, string Serie)
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
