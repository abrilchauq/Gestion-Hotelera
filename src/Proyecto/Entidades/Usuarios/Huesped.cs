using Proyecto.Entidades.Reservacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

public class Huesped : Persona, IBuscar
{
    public Guid idHuesped { get; private set; }
    public Habitacion Habitacion { get; private set; }
    public Huesped(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio, eTipoUsuario.Huesped)
    {
        this.idHuesped = Guid.NewGuid();
    }

    public void AsignarHabitacion(Habitacion habitacion)
    {
        Habitacion = habitacion;
    }
    public void BuscarHabitacion(Habitacion habitacion)
    {
        //var  = .FirstOrDefault(x => x.Disponibilidad);

    }
    public void Reservar(Habitacion habitacion)
    {

    }

    public void buscarHabitacion(eTipoEstilo estilo, DateTime fechaInicio, int duracionDias)
    {
        throw new NotImplementedException();
    }

    public void CancelarReserva(Reserva reserva)
    {

    }
}
