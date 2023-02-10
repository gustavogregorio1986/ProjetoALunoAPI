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
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _repository;

        public void Adicionar(Turma turma)
        {
            _repository.Adicionar(turma);
        }

        public void DeleteTurma(int id)
        {
            _repository.DeleteTurma(id);
        }

        public List<Turma> ListarMateria()
        {
            return _repository.ListarMateria();
        }

        public Turma TurmaPorId(int id)
        {
            _repository.TurmaPorId(id);
        }

        public void UpdateTurma(Turma turma)
        {
            throw new NotImplementedException();
        }
    }
}
