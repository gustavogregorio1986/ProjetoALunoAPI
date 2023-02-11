using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface IAvaliacaoRepository
    {
        void Adicionar(AvaliacaoDTO avaliacao);

        void UpdateAvaliacao(AvaliacaoDTO avaliacao);

        void DeleteaAvaliacao(int id);

        List<AvaliacaoDTO> ListarAvaliacao();

        AvaliacaoDTO AvaliacaoPorId(int id);
    }
}
