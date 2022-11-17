using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Servicios;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Mucama")]
public class Mucama : Persona
{
    public Mucama(Guid id, string email, string nombre, string apellido, string telefono, string domicilio)
        : base(id, email, nombre, apellido, telefono, domicilio, eTipoUsuario.Mucama)
    {

    }

    public void AsignarHabitacion(Habitacion habitacion, ServicioLimpieza servicioLimpieza)
    {
        habitacion.AgregarServicioLimpieza(servicioLimpieza);
    }
}
