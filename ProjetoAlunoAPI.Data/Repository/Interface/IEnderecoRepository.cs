using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface IEnderecoRepository
    {
        void Adicionar(Endereco endereco);

        void UpdateAluno(Endereco endereco);

        void DeleteEndereco(int id);

        List<Endereco> ListarEndereco();

        Endereco AlunoPorId(int id);
    }
}
