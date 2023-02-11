using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Repository.Interface
{
    public interface IAdministradorRepository
    {
        void Adicionar(AdministradorDTO administrador);

        void UpdateAdm(AdministradorDTO administrador);

        void DeleteAdm(int id);

        List<AdministradorDTO> ListarAdm();

        AdministradorDTO AdministradorPorId(int id);
    }
}
