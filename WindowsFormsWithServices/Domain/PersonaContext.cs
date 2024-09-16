using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    internal class AcademiaContext : DbContext
    {
        internal DbSet<Persona> Personas { get; set; }
        internal DbSet<Plan> Planes { get; set; }

        internal AcademiaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=AcademiaDb");
    }
}
