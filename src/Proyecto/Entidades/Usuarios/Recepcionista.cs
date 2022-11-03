using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
public class Recepcionista : Usuario
{
    public Guid IdRecepcionista { get; private set; }
    public List<Reserva> Reservas { get; private set; }
    public List<Habitacion> Habitaciones { get; private set; }
    public Recepcionista(string email, string nombre, string apellido
    , string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.IdRecepcionista = Guid.NewGuid();
        this.Reservas = new List<Reserva>();
        this.Habitaciones = new List<Habitacion>();
    }
    public void agregarHabitacion(Habitacion habitacion)
    {
        this.Habitaciones.Add(habitacion);
    }

    public void crearReserva(eTipoHabitacion tipo, DateTime fechaHospedaje, Huesped huesped)
    {
        this.Reservas.Add(new Reserva(tipo, fechaHospedaje, huesped));
    }

    public void cancelarReserva(Guid IdReserva)
    {
        var reserva = Reservas.FirstOrDefault(x => x.IdReserva == IdReserva);
        reserva!.Cancelar();
    }

    public void checkIn(Huesped huesped, Guid idReserva)
    { 
        var reserva = Reservas.FirstOrDefault(x => x.IdReserva == idReserva);
        reserva!.Completada();
        var habitacion = Habitaciones.FirstOrDefault(x => x.Disponibilidad);
        huesped.AsignarHabitacion(habitacion);
    }

    public void checkOut(Huesped huesped)
    { 
        var habitacion = Habitaciones.FirstOrDefault(X => X.IdHabitacion == huesped.Habitacion.IdHabitacion);
        habitacion!.Liberar();
    }
}