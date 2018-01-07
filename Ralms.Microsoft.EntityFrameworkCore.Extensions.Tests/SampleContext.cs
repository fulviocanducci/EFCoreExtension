using Microsoft.EntityFrameworkCore;

namespace Ralms.Microsoft.EntityFrameworkCore.Tests
{
    public class SampleContext : DbContext
    {
        public DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\Sistemas;Database=TesteExtensao;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelo)
        {
            modelo.CreateFunctionDateDiff();
        }
    }
}
