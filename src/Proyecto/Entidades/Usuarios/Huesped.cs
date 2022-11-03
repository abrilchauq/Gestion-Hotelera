
using Proyecto.Entidades.Unidades;

namespace Proyecto.Entidades.Usuarios;

public class Huesped : Usuario
{
    public Guid idHuesped { get; private set; }
    public Habitacion Habitacion { get; private set; }
    public Huesped(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.idHuesped = Guid.NewGuid();
    }

    public void AsignarHabitacion(Habitacion habitacion)
    {
        Habitacion = habitacion;
    }
    public void BuscarHabitacion(Habitacion habitacion)
    {
        var  = .FirstOrDefault(x => x.Disponibilidad);

    }
    public void Reservar(Habitacion habitacion)
    {

    }
}
