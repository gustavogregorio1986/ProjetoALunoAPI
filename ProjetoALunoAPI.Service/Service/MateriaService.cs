using ProjetoAlunoAPI.Data.Repository.Interface;
using ProjetoALunoAPI.Dominio.Dominio;
using ProjetoALunoAPI.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoALunoAPI.Service.Service
{
    public class MateriaService : IMateriaService
    {
        private readonly IMateriaRepository _repository;

        public void Adicionar(Materia materia)
        {
            _repository.Adicionar(materia);
        }

        public void DeleteMatewria(int id)
        {
            _repository.DeleteMatewria(id);
        }

        public List<Materia> ListarMateria()
        {
            return _repository.ListarMateria();
        }

        public Materia MateriaPorId(int id)
        {
            return _repository.MateriaPorId(id);
        }

        public void UpdateMateria(Materia materia)
        {
            _repository.UpdateMateria(materia);
        }
    }
}
