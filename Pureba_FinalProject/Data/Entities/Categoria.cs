using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pureba_FinalProject.Data.Entities
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string NombreC { get; set; } = null!;

        public static Categoria Create(string nombreC)
            => new()
            {
                NombreC = nombreC
            };
        public bool Update(string nombreC)
        {
            var save = false;
            if (NombreC != nombreC)
            {
                NombreC = nombreC; save = true;
            }
            return save;
        }
    }
}
