﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pureba_FinalProject.Data.Entities
{
    [Table("Modelos")]
    public class Modelo
    {
        [Key]
        public int Id { get; set; }
        public string NombreM { get; set; } = null!;

        public static Modelo Create(string nombreM)
            => new()
            {
                NombreM = nombreM
            };
        public bool Update(string nombreM)
        {
            var save = false;
            if (NombreM != nombreM)
            {
                NombreM = nombreM; save = true;
            }
            return save;
        }
        [ForeignKey(nameof(Marca))]
        public virtual Marca? Marcas { get; set; }
    }
}
