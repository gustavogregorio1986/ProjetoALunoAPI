using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface IMateriaRepository
    {
        void Adicionar(Materia materia);

        void UpdateMateria(Materia materia);

        void DeleteMatewria(int id);

        List<Materia> ListarMateria();

        Materia MateriaPorId(int id);
    }
}
