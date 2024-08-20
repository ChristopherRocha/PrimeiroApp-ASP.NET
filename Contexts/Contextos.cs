
using Microsoft.EntityFrameworkCore;
using ProjetoGerenciarTarefas.Models;

namespace ProjetoGerenciarTarefas.Contexts
{
    public class Contextos:DbContext
    {

        public DbSet<ParaFazer> aFazeres => Set<ParaFazer>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = BancoTarefas.sqlite3");
        }

    }
}
