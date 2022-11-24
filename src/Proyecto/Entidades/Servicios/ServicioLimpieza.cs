using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Unidades;

namespace Proyecto.Entidades.Servicios;
[Table("ServicioLimpieza")]

public class ServicioLimpieza
{

    [Key]
    [Required]
    public Guid IdServicioLimpieza { get; private set; }
    [StringLength(50)]
    public string? descripcion { get; private set; }
    [Required]
    public DateTime comienzo { get; private set; }
    [Required]
    public int duracion { get; private set; }
    public Habitacion? habitacion { get; set; }

    public ServicioLimpieza(string descripcion, DateTime comienzo, int duracion, Habitacion habitacion)
    {
        this.IdServicioLimpieza = Guid.NewGuid();
        this.descripcion = descripcion;
        this.comienzo = comienzo;
        this.duracion = duracion;
        this.habitacion = habitacion;

    }

    public ServicioLimpieza()
    {

    }

    public void asignarHabitacion(Habitacion habitacion)
    {
        this.habitacion = habitacion;
    }
}


