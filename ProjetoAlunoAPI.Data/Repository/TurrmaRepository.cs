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

        public void Adicionar(TurmaDTO turma)
        {
            _db.Add(turma);
        }

        public void DeleteTurma(int id)
        {
            _db.Remove(id);
        }

        public List<TurmaDTO> ListarMateria()
        {
            return _db.Set<TurmaDTO>().ToList();
        }

        public TurmaDTO TurmaPorId(int id)
        {
            return _db.Set<TurmaDTO>().FirstOrDefault(m => m.Id == id);
        }

        public void UpdateTurma(TurmaDTO turma)
        {
            _db.Update(turma);
        }
    }
}
