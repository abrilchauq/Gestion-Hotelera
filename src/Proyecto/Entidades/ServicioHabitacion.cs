namespace Proyecto.Entidades;

public class ServicioHabitacion : ServicioHotel
{
    public Guid IdServicioHabitacion { get; private set; }
    public ServicioHabitacion(double Precio, DateTime FechaHora)
        : base(Precio, FechaHora)
    {
        this.IdServicioHabitacion = Guid.NewGuid();
    }
}
