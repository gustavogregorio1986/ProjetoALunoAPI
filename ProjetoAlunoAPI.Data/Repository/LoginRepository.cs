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

        public void Adicionar(Login login)
        {
            _db.Add(login);
        }

        public void DeleteLogin(int id)
        {
            _db.Remove(id);
        }

        public List<Login> ListarLogin()
        {
            return _db.Set<Login>().ToList();
        }

        public Login LoginPorId(int id)
        {
            return _db.Set<Login>().FirstOrDefault(x => x.Id == id);
        }

        public void UpdateLogin(Login login)
        {
            _db.Update(login);
        }
    }
}
