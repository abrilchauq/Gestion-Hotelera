using Proyecto.Entidades.Unidades;

namespace Proyecto.Entidades.Servicios;

public class ServicioLimpieza
{
    public string? descripcion { get; private set; }
    public DateTime comienzo { get; private set; }
    public int duracion { get; private set; }
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


