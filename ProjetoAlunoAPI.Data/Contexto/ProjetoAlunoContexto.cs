using Microsoft.EntityFrameworkCore;
using ProjetoALunoAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunoAPI.Data.Contexto
{
    public class ProjetoAlunoContexto : DbContext 
    {
        public ProjetoAlunoContexto(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<AdministradorDTO> Administradores { get; set; }

        public DbSet<AlunoDTO> Alunos { get; set; }

        public DbSet<AvaliacaoDTO> Avaliacoes { get; set; }

        public DbSet<EnderecoDTO> Enderecos { get; set; }

        public DbSet<LoginDTO> logins { get; set; }

        public DbSet<MateriaDTO> Materias { get; set; }

        public DbSet<TurmaDTO> Turmas { get; set; }
    }
}
