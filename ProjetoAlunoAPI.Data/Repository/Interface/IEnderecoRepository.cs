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
        void Adicionar(EnderecoDTO endereco);

        void UpdateEndereco(EnderecoDTO endereco);

        void DeleteEndereco(int id);

        List<EnderecoDTO> ListarEndereco();

        EnderecoDTO EnderecoPorId(int id);
    }
}
