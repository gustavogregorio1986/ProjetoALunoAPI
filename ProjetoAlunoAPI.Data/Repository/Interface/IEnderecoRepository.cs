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

        void UpdateEndereco(Endereco endereco);

        void DeleteEndereco(int id);

        List<Endereco> ListarEndereco();

        Endereco EnderecoPorId(int id);
    }
}
