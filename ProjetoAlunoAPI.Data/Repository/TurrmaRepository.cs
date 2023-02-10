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
    public class TurrmaRepository : ITurmaRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(Turma turma)
        {
            _db.Add(turma);
        }

        public void DeleteTurma(int id)
        {
            _db.Remove(id);
        }

        public List<Turma> ListarMateria()
        {
            return _db.Set<Turma>().ToList();
        }

        public Turma TurmaPorId(int id)
        {
            return _db.Set<Turma>().FirstOrDefault(m => m.Id == id);
        }

        public void UpdateTurma(Turma turma)
        {
            _db.Update(turma);
        }
    }
}
