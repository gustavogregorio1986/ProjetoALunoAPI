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
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(Avaliacao avaliacao)
        {
            _db.Add(avaliacao);
        }

        public Avaliacao AvaliacaoPorId(int id)
        {
            return _db.Set<Avaliacao>().FirstOrDefault(x => x.Id == id);
        }

        public void DeleteaAvaliacao(int id)
        {
            _db.Remove(id);
        }

        public List<Avaliacao> ListarAvaliacao()
        {
            return _db.Set<Avaliacao>().ToList();
        }

        public void UpdateAvaliacao(Avaliacao avaliacao)
        {
            _db.Update(avaliacao);
        }
    }
}
