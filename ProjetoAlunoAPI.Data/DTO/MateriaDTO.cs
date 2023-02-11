using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    
    public class MateriaDTO
    {
        
        public int Id { get; set; }

        public string NomeMateria { get; set; }

        public Turma Turma { get; set; }

       
        public int Id_Turma { get; set; }
    }
}
