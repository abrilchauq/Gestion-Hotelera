using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Servicios;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Mucama")]
public class Mucama : Persona
{
    [Key]
    [Required]
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
