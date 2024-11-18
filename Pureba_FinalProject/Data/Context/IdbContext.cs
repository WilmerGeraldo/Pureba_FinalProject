using Microsoft.EntityFrameworkCore;
using Pureba_FinalProject.Data.Entities;

namespace Pureba_FinalProject.Data.Context
{
    public interface IdbContext
    {
        DbSet<Categoria> categorias { get; set; }
        DbSet<Marca> marcas { get; set; }
        DbSet<Modelo> modelos { get; set; }
        DbSet<Producto> productos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}