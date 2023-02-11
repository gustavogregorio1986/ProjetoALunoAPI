using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface IAlunoRepository
    {
        void Adicionar(AlunoDTO aluno);

        void UpdateAluno(AlunoDTO aluno);

        void DeleteAluno(int id);

        List<AlunoDTO> ListarAluno();

        AlunoDTO AlunoPorId(int id);
    }
}
