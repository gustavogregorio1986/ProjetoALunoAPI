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
        void Adicionar(Avaliacao avaliacao);

        void UpdateAvaliacao(Avaliacao avaliacao);

        void DeleteaAvaliacao(int id);

        List<Avaliacao> ListarAvaliacao();

        Avaliacao AvaliacaoPorId(int id);
    }
}
