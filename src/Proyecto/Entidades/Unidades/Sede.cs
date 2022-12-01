using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Unidades;
[Table("Sede")]
public class Sede
{
    [Key]
    [Required]
    public Guid idSede { get; set; }
    [StringLength(50)]
    public string Nombre { get; set; }
    [Required]
    public string Ubicacion { get; set; }
    public List<Habitacion> Habitaciones { get; set; }
    public Sede(string nombre, string ubicacion)
    {
        this.idSede = Guid.NewGuid();
        this.Nombre = nombre;
        this.Ubicacion = ubicacion;
        this.Habitaciones = new List<Habitacion>();
    }

    public void Actualizar(string Nombre, string Ubicacion)
    {
        this.Nombre = Nombre;
        this.Ubicacion = Ubicacion;
    }
}