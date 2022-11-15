using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Unidades;

namespace Proyecto.Entidades.Servicios;
[Table("ServicioLimpieza")]

public class ServicioLimpieza
{
    [StringLength(50)]
    public string? descripcion { get; private set; }
    [Required]
    public DateTime comienzo { get; private set; }
    [Required]
    public int duracion { get; private set; }
    [Required]
    public Habitacion? habitacion { get; set; }

    public ServicioLimpieza(string descripcion, DateTime comienzo, int duracion)
    {
        this.descripcion = descripcion;
        this.comienzo = comienzo;
        this.duracion = duracion;
    }

    public void asignarHabitacion(Habitacion habitacion)
    {
        this.habitacion = habitacion;
    }
}


