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
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public void Adicionar(Endereco endereco)
        {
            _repository.Adicionar(endereco);
        }

        public void DeleteEndereco(int id)
        {
            _repository.DeleteEndereco(id);
        }

        public Endereco EnderecoPorId(int id)
        {
            return _repository.EnderecoPorId(id);
        }

        public List<Endereco> ListarEndereco()
        {
            return _repository.ListarEndereco();
        }

        public void UpdateEndereco(Endereco endereco)
        {
            _repository.UpdateEndereco(endereco);
        }
    }
}
