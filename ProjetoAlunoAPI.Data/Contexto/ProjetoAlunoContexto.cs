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

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Login> logins { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Turma> Turmas { get; set; }
    }
}
