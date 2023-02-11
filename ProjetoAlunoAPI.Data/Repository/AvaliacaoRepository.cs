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

        public void Adicionar(AvaliacaoDTO avaliacao)
        {
            _db.Add(avaliacao);
        }

        public AvaliacaoDTO AvaliacaoPorId(int id)
        {
            return _db.Set<AvaliacaoDTO>().FirstOrDefault(x => x.Id == id);
        }

        public void DeleteaAvaliacao(int id)
        {
            _db.Remove(id);
        }

        public List<AvaliacaoDTO> ListarAvaliacao()
        {
            return _db.Set<AvaliacaoDTO>().ToList();
        }

        public void UpdateAvaliacao(AvaliacaoDTO avaliacao)
        {
            _db.Update(avaliacao);
        }
    }
}
