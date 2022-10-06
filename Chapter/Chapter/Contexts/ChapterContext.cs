using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options):base(options) 
        { 
        }
        //vms utilizat esse metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            { 
                // cada provedor tem sua sintaxe para expecificação
                optionsBuilder.UseSqlServer("Data Source = FRANKLINSOUL\\SQLEXPRESS;initial catalog = Chapter; Integrated Security = trye");
            }
        }

        // Dbset representa as entidades que serao utilizados nas operações de leitura, criação , atualização e exclusao
        public DbSet<Livro> Livros { get; set; }
    }
}
