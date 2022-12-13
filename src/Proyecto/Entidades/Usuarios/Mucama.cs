using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Servicios;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Mucama")]
public class Mucama : Persona
{
    public Mucama(string email, string nombre, string apellido, string telefono, string domicilio)
        : base(email, nombre, apellido, telefono, domicilio, eTipoUsuario.Mucama)
    {

    }

    public void AsignarHabitacion(Habitacion habitacion, ServicioLimpieza servicioLimpieza)
    {
        habitacion.AgregarServicioLimpieza(servicioLimpieza);
    }

    public void Actualizar(string email, string nombre, string apellido, string telefono, string domicilio)
    {
        this.Email = email;
        this.Nombre = nombre;
        this.apellido = apellido;
        this.Telefono = telefono;
        this.Domicilio = domicilio;
    }
}
