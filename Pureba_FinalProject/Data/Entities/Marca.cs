using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pureba_FinalProject.Data.Entities
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        public string NombreMc { get; set; } = null!;


        public static Marca Create(string nombreMc)
            => new()
            {
                NombreMc = nombreMc
            };
        public bool Update(string nombreMc)
        {
            var save = false;
            if (NombreMc != nombreMc)
            {
                NombreMc = nombreMc; save = true;
            }
            return save;
        }
    }
}
