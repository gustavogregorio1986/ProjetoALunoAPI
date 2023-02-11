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

        public void Adicionar(AlunoDTO aluno)
        {
            _db.Add(aluno);
        }

        public AlunoDTO AlunoPorId(int id)
        {
            return _db.Set<AlunoDTO>().FirstOrDefault(x => x.Id == id);
        }

        public void DeleteAluno(int id)
        {
            _db.Remove(id);
        }

        public List<AlunoDTO> ListarAluno()
        {
            return _db.Set<AlunoDTO>().ToList();
        }

        public void UpdateAluno(AlunoDTO aluno)
        {
            _db.Update(aluno);
        }
    }
}
