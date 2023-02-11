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

        public void Adicionar(EnderecoDTO endereco)
        {
            _db.Add(endereco);
        }

        public void DeleteEndereco(int id)
        {
            _db.Remove(id);
        }

        public EnderecoDTO EnderecoPorId(int id)
        {
            return _db.Set<EnderecoDTO>().FirstOrDefault(x => x.Id == id);
        }

        public List<EnderecoDTO> ListarEndereco()
        {
            return _db.Set<EnderecoDTO>().ToList();
        }

        public void UpdateEndereco(EnderecoDTO endereco)
        {
            _db.Update(endereco);
        }
    }
}
