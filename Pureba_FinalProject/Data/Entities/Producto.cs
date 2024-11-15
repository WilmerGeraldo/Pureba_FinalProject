using Pureba_FinalProject.Components.Pages.Admin.Marcas;
using Pureba_FinalProject.Components.Pages.Admin.Modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pureba_FinalProject.Data.Entities;
[Table("Productos")]

public class Producto
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Marca { get; set; }
    public Date FechaL { get; set; }
    public string Color { get; set; }
    public int Cantidad { get; set; }
    public int? ModeloId { get; set; }
    public decimal Precio { get; set; } = 0;
    public string? Descripcion { get; set; }
    public string IMG { get; set; }

    #region Metodos
    public static Producto Create(string nombre, string marca, Date fechaL,string color,int cantidad, int? modeloId = null, decimal precio = 0, string? descripcion = null, string img)
        => new()
        {
            Nombre = nombre,
            Marca = marca,
            FechaL = fechaL,
            Color = color,
            Cantidad = cantidad,
            ModeloId = modeloId,
            Precio = precio,
            Descripcion = descripcion,
            IMG = img
        };

    public bool Update(string nombre, string marca, Date fechaL, string color, int cantidad, int? modeloId = null, decimal precio = 0, string? descripcion = null, string img)
    {
        var save = false;
        if (Nombre != nombre)
        {
            Nombre = nombre; save = true;
        }
        if (Marca != marca)
        {
            Marca = marca; save = true;
        }
        if (FechaL != fechaL)
        {
            FechaL = fechaL; save = true;
        }
        if(Color != color)
        {
            Color = color; save = true;
        }
        if(Cantidad != cantidad)
        {
            Cantidad = cantidad; save = true;
        }
        if (ModeloId != modeloId)
        {
            ModeloId = modeloId; save = true;
        }
        if (Precio != precio)
        {
            Precio = precio; save = true;
        }
        if (Descripcion != descripcion)
        {
            Descripcion = descripcion; save = true;
        }
        return save;
    }
    #endregion Metodos

    #region Relaciones
    [ForeignKey(nameof(ModeloId))]
    public virtual Modelo? Modelos { get; set; }

    [ForeignKey(nameof(Marca))]
    public virtual Marca? Marcas { get; set; }

    #endregion
}