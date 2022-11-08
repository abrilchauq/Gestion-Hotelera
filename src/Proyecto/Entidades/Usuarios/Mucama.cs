using Proyecto.Entidades.Servicios;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

public class Mucama : Persona
{
    public Guid IdMucama { get; private set; }
    public Mucama(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio, eTipoUsuario.Mucama)
    {
        this.IdMucama = Guid.NewGuid();
    }

    public void AsignarHabitacion(Habitacion habitacion, ServicioLimpieza servicioLimpieza)
    {
        habitacion.AgregarServicioLimpieza(servicioLimpieza);
    }
}
