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
        void Adicionar(LoginDTO login);

        void UpdateLogin(LoginDTO login);

        void DeleteLogin(int id);

        List<LoginDTO> ListarLogin();

        LoginDTO LoginPorId(int id);
    }
}
