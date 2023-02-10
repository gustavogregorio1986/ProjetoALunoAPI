using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoALunoAPI.Service.Service.Interface
{
    public interface IAdministradorService
    {
        void Adicionar(Administrador administrador);

        void UpdateAdm(Administrador administrador);

        void DeleteAdm(int id);

        List<Administrador> ListarAdm();

        Administrador AdministradorPorId(int id);
    }
}
