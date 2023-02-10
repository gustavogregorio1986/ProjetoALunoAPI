using ProjetoAlunoAPI.Data.Contexto;
using ProjetoAlunoAPI.Data.Repository.Interface;
using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(Endereco endereco)
        {
            _db.Add(endereco);
        }

        public void DeleteEndereco(int id)
        {
            _db.Remove(id);
        }

        public Endereco EnderecoPorId(int id)
        {
            return _db.Set<Endereco>().FirstOrDefault(x => x.Id == id);
        }

        public List<Endereco> ListarEndereco()
        {
            return _db.Set<Endereco>().ToList();
        }

        public void UpdateEndereco(Endereco endereco)
        {
            _db.Update(endereco);
        }
    }
}
