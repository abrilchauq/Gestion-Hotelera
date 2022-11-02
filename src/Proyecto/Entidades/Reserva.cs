namespace Proyecto.Entidades;
public class Reserva
{
    public Guid IdReserva { get; private set; }
    public bool estado { get; private set; } = false;
    public DateTime fechaReserva { get; private set; }
    public DateTime fechaHospedaje { get; private set; }
    public string tipoHabitacion { get; private set; }
    public List<Huesped> huespedes { get; private set; }
    public Reserva(bool estado, DateTime fechaReserva, DateTime fechaHospedaje, string tipoHabitacion)
    {
        this.estado = estado;
        this.fechaReserva = fechaReserva;
        this.fechaHospedaje = fechaHospedaje;
        this.huespedes = new List<Huesped>();
        this.IdReserva = Guid.NewGuid();
    }
}
