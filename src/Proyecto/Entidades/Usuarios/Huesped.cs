using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Huesped")]
public class Huesped : Persona
{
    [Required]
    public Habitacion Habitacion { get; private set; }
    public Huesped(Guid id, string email, string nombre, string apellido, string telefono, string domicilio)
        : base(id, email, nombre, apellido, telefono, domicilio, eTipoUsuario.Huesped)
    {

    }

    public void AsignarHabitacion(Habitacion habitacion)
    {
        Habitacion = habitacion;
    }

    public void CrearReserva(Recepcionista recepcionista, Reserva reserva)
    {
        recepcionista.CrearReserva(reserva);
    }

    public List<Habitacion> buscarHabitacion(Recepcionista recepcionista, eTipoEstilo estilo, DateTime fechaInicio, int duracionDias)
    {
        return recepcionista.buscarHabitacion(estilo, fechaInicio, duracionDias);
    }

    public void CancelarReserva(Recepcionista recepcionista, Reserva reserva)
    {
        recepcionista.CancelarReserva(reserva.IdReserva);
    }

    public void EntregarLlave()
    {
        Habitacion.Liberar();
    }
}
