using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Unidades;
[Table("Sede")]
public class Sede
{
    [StringLength(50)]
    public string Nombre { get; set; }
    [Required]
    public string Ubicacion { get; set; }
    public List<Habitacion> Habitaciones { get; set; }
    public Sede(string nombre, string ubicacion)
    {
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Habitaciones = new List<Habitacion>();
    }
}