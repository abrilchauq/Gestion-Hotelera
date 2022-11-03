using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Servicios;
using Proyecto.Entidades.Unidades;
using Proyecto.Entidades.Usuarios;

namespace Proyecto.Entidades;

public class Sistema
{
    public Guid IdSistema { get; private set; }
    public List<Usuario> Usuarios { get; private set; }
    public List<Habitacion> Habitaciones { get; private set; }
    public List<Reserva> Reservas { get; private set; }
    public ReservaHistorial? ReservaHistorial { get; private set; }
    public ServicioLimpieza? ServicioLimpieza { get; private set; }
    public List<Huesped> Huespedes { get; private set; }
    public List<Invitado> Invitados { get; private set; }
    public Sistema(ServicioLimpieza servicioLimpieza)
    {
        this.IdSistema = Guid.NewGuid();
        this.Usuarios = new List<Usuario>();
        this.Habitaciones = new List<Habitacion>();
        this.Huespedes = new List<Huesped>();
        this.Reservas = new List<Reserva>();
        this.Invitados = new List<Invitado>();
        this.ServicioLimpieza = servicioLimpieza;
    }

    public void AgregarReserva(Reserva reserva)
    {
        this.Reservas.Add(reserva);
    }
}
