using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

[Table("Recepcionista")]
public class Recepcionista : Persona, IBuscar
{
    public List<Reserva> Reservas { get; private set; }
    public List<Habitacion> Habitaciones { get; private set; }
    public List<Llave> Llaves { get; private set; }

    public Recepcionista(string email, string nombre, string apellido, string telefono, string domicilio)
        : base(email, nombre, apellido, telefono, domicilio, eTipoUsuario.Recepcionista)
    {
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
        if (reserva!.Estado == eEstadoReserva.Activa)
        {
            if (DateTime.Now <= reserva.FechaReserva)
            {
                reserva.Cancelar();
            }
        }
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
        huesped.EntregarLlave();
    }

    public List<Habitacion> buscarHabitacion(eTipoEstilo estilo, DateTime fechaInicio, int duracionDias)
    {
        return Habitaciones.Where(x => x.Tipo == estilo).ToList();
    }

    public void Actualizar(string email, string nombre, string apellido, string telefono, string domicilio)
    {
        this.Email = email;
        this.Nombre = nombre;
        this.Telefono = Telefono;
        this.Domicilio = Domicilio;
    }
}