using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoALunoAPI.Service.Service.Interface
{
    public interface IAlunoService
    {
        void Adicionar(Aluno aluno);

        void UpdateAluno(Aluno aluno);

        void DeleteAluno(int id);

        List<Aluno> ListarAluno();

        Aluno AlunoPorId(int id);
    }
}
