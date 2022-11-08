using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
public class Recepcionista : Persona, IBuscar
{
    public Guid IdRecepcionista { get; private set; }
    public List<Reserva> Reservas { get; private set; }
    public List<Habitacion> Habitaciones { get; private set; }
    public List<Llave> Llaves { get; private set; }

    public Recepcionista(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio, eTipoUsuario.Recepcionista)
    {
        this.IdRecepcionista = Guid.NewGuid();
        this.Reservas = new List<Reserva>();
        this.Habitaciones = new List<Habitacion>();
    }

    public void CrearReserva(Reserva reserva)
    {
        this.Reservas.Add(reserva);
    }

    public void CancelarReserva(Guid IdReserva)
    {
        var reserva = Reservas.FirstOrDefault(x => x.IdReserva == IdReserva);
        reserva!.Cancelar();
    }

    public void checkIn(Huesped huesped, Guid idReserva)
    {
        var reserva = Reservas.FirstOrDefault(x => x.IdReserva == idReserva);
        if (reserva is not null)
        {
            var habitacion = Habitaciones.FirstOrDefault(x => x.Tipo == reserva!.Tipo);
            if (habitacion!.Estado == eEstadoHabitacion.Disponible)
            {
                reserva!.CheckIn();
            }
        }
        else
            throw new Exception("No se encontro la reserva");
    }

    public void checkOut(Huesped huesped)
    {
        // var habitacion = Habitaciones.FirstOrDefault(X => X.IdHabitacion == huesped.Habitacion.IdHabitacion);
        // habitacion!.Liberar();
    }

    public void buscarHabitacion(eTipoEstilo estilo, DateTime fechaInicio, int duracionDias)
    {
        var habitacion = Habitaciones.Where(x => x.estilo == List<Habitacion> Habitaciones);
    }
}