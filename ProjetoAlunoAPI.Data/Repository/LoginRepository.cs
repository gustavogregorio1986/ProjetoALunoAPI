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
    public class LoginRepository : ILoginRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(LoginDTO login)
        {
            _db.Add(login);
        }

        public void DeleteLogin(int id)
        {
            _db.Remove(id);
        }

        public List<LoginDTO> ListarLogin()
        {
            return _db.Set<LoginDTO>().ToList();
        }

        public LoginDTO LoginPorId(int id)
        {
            return _db.Set<LoginDTO>().FirstOrDefault(x => x.Id == id);
        }

        public void UpdateLogin(LoginDTO login)
        {
            _db.Update(login);
        }
    }
}
