namespace Proyecto.Entidades;
public class Reserva
{
    public Guid IdReserva { get; private set; }
    public bool Estado { get; private set; } = false;
    public DateTime FechaReserva { get; private set; }
    public DateTime FechaHospedaje { get; private set; }
    public string TipoHabitacion { get; private set; } = null!;
    public List<Huesped> Huespedes { get; private set; }
    public Reserva(bool estado, DateTime fechaReserva, DateTime fechaHospedaje, string tipoHabitacion)
    {
        this.Estado = estado;
        this.FechaReserva = fechaReserva;
        this.FechaHospedaje = fechaHospedaje;
        this.Huespedes = new List<Huesped>();
        this.IdReserva = Guid.NewGuid();
    }
}
