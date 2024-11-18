using Microsoft.EntityFrameworkCore;
using Pureba_FinalProject.Data.Entities;

namespace Pureba_FinalProject.Data.Context
{
    public class dbContext : DbContext, IdbContext
    {
        private readonly IConfiguration confi;

        public dbContext(IConfiguration confi)
        {
            this.confi = confi;
        }

        public DbSet<Producto> productos { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Modelo> modelos { get; set; }
        public DbSet<Marca> marcas { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(confi.GetConnectionString("MSSQL"));
        }
    }
}
