using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface ITurmaRepository
    {
        void Adicionar(TurmaDTO turma);

        void UpdateTurma(TurmaDTO turma);

        void DeleteTurma(int id);

        List<TurmaDTO> ListarMateria();

        TurmaDTO TurmaPorId(int id);
    }
}
