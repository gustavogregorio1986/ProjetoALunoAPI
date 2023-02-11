using ProjetoAlunoAPI.Data.Contexto;
using ProjetoAlunoAPI.Data.Repository.Interface;
using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository
{
    public class MaterialRepository : IMateriaRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(MateriaDTO materia)
        {
            _db.Add(materia);
        }

        public void DeleteMatewria(int id)
        {
            _db.Remove(id);
        }

        public List<MateriaDTO> ListarMateria()
        {
            return _db.Set<MateriaDTO>().ToList();
        }

        public MateriaDTO MateriaPorId(int id)
        {
            return _db.Set<MateriaDTO>().FirstOrDefault(m => m.Id == id);
        }

        public void UpdateMateria(MateriaDTO materia)
        {
            _db.Update(materia);
        }
    }
}
