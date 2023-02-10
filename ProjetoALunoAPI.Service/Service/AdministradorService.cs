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
    public class AdministradorService : IAdministradorService
    {
        private readonly IAdministradorRepository _repository;

        public void Adicionar(Administrador administrador)
        {
            _repository.Adicionar(administrador);
        }

        public Administrador AdministradorPorId(int id)
        {
            return _repository.AdministradorPorId(id);
        }

        public void DeleteAdm(int id)
        {
            _repository.DeleteAdm(id);
        }

        public List<Administrador> ListarAdm()
        {
           return _repository.ListarAdm();
        }

        public void UpdateAdm(Administrador administrador)
        {
            _repository.UpdateAdm(administrador);
        }
    }
}
