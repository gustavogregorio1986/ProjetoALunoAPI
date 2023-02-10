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
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;

        public void Adicionar(Login login)
        {
            _repository.Adicionar(login);
        }

        public void DeleteLogin(int id)
        {
            _repository.DeleteLogin(id);
        }

        public List<Login> ListarLogin()
        {
           return _repository.ListarLogin();
        }

        public Login LoginPorId(int id)
        {
            return _repository.LoginPorId(id);
        }

        public void UpdateLogin(Login login)
        {
            _repository.UpdateLogin(login);
        }
    }
}
