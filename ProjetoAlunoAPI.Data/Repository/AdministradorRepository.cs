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
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly ProjetoAlunoContexto _db;

        public void Adicionar(Administrador administrador)
        {
            _db.Add(administrador);
        }

        public Administrador AdministradorPorId(int id)
        {
            return _db.Set<Administrador>().FirstOrDefault(x => x.Id == id);
        }

        public void DeleteAdm(int id)
        {
            _db.Remove(id);
        }

        public List<Administrador> ListarAdm()
        {
            return _db.Set<Administrador>().ToList();
        }

        public void UpdateAdm(Administrador administrador)
        {
            _db.Update(administrador);
        }
    }
}
