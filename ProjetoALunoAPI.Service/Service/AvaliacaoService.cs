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
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _repository;

        public void Adicionar(Avaliacao avaliacao)
        {
            _repository.Adicionar(avaliacao);
        }

        public Avaliacao AvaliacaoPorId(int id)
        {
            return _repository.AvaliacaoPorId(id);
        }

        public void DeleteaAvaliacao(int id)
        {
            _repository.DeleteaAvaliacao(id);
        }

        public List<Avaliacao> ListarAvaliacao()
        {
            return _repository.ListarAvaliacao();
        }

        public void UpdateAvaliacao(Avaliacao avaliacao)
        {
            _repository.UpdateAvaliacao(avaliacao);
        }
    }
}
