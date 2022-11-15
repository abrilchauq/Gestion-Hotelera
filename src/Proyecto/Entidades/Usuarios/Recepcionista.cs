using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Recepcionista")]
public class Recepcionista : Persona, IBuscar
{
    [Key]
    [Required]
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
}