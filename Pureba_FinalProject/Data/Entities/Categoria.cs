using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pureba_FinalProject.Data.Entities
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;


        public static Categoria Create(string nombre)
            => new()
            {
                Nombre = nombre
            };
        public bool Update(string nombre)
        {
            var save = false;
            if (Nombre != nombre)
            {
                Nombre = nombre; save = true;
            }
            return save;
        }
    }
}
