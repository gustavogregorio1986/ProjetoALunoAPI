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
        void Adicionar(Turma turma);

        void UpdateTurma(Turma turma);

        void DeleteTurma(int id);

        List<Turma> ListarMateria();

        Turma TurmaPorId(int id);
    }
}
