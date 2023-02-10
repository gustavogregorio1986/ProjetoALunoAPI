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
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _repository;

        public void Adicionar(Aluno aluno)
        {
            _repository.Adicionar(aluno);
        }

        public Aluno AlunoPorId(int id)
        {
          return  _repository.AlunoPorId(id);
        }

        public void DeleteAluno(int id)
        {
            _repository.DeleteAluno(id);
        }

        public List<Aluno> ListarAluno()
        {
            return _repository.ListarAluno();
        }

        public void UpdateAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
