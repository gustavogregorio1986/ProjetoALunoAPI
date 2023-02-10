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
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(Aluno aluno)
        {
            _db.Add(aluno);
        }

        public Aluno AlunoPorId(int id)
        {
            return _db.Set<Aluno>().FirstOrDefault(x => x.Id == id);
        }

        public void DeleteAluno(int id)
        {
            _db.Remove(id);
        }

        public List<Aluno> ListarAluno()
        {
            return _db.Set<Aluno>().ToList();
        }

        public void UpdateAluno(Aluno aluno)
        {
            _db.Update(aluno);
        }
    }
}
