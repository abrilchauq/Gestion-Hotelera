namespace Proyecto.Entidades;

public class Sistema
{
    public Guid idSistema { get; private set; }
    public List<Usuario> Usuarios { get; private set; }
    public List<Habitacion> Habitaciones { get; private set; }
    public Reserva Reserva { get; private set; }
    public ReservaHistorial ReservaHistorial { get; private set; }
    public ServicioLimpieza ServicioLimpieza { get; private set; }
    public List<Huesped> Huespedes { get; private set; }
    public Sistema()
    {
        this.idSistema = Guid.NewGuid();
        this.Usuarios = new List<Usuario>();
        this.Habitaciones = new List<Habitacion>();
        this.Huespedes = new List<Huesped>();
    }
}