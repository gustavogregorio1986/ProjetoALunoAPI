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
        void Adicionar(MateriaDTO materia);

        void UpdateMateria(MateriaDTO materia);

        void DeleteMatewria(int id);

        List<MateriaDTO> ListarMateria();

        MateriaDTO MateriaPorId(int id);
    }
}
