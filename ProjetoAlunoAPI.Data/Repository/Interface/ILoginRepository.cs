using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface ILoginRepository
    {
        void Adicionar(Login login);

        void UpdateLogin(Login login);

        void DeleteLogin(int id);

        List<Login> ListarLogin();

        Login LoginPorId(int id);
    }
}
