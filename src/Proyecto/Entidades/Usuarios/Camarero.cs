using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Facturacion;
using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Camarero")]
public class Camarero : Persona
{
    public Camarero(string email, string nombre, string apellido, string telefono, string domicilio)
        : base(email, nombre, apellido, telefono, domicilio, eTipoUsuario.Camarero)
    {

    }

    public void AgregarRoomCharge(Habitacion habitacion, RoomCharge roomCharge)
    {
        habitacion.agregarRoomCharge(roomCharge);
    }

    public void Actualizar(string email, string nombre, string apellido, string telefono, string domicilio)
    {
        this.Email = Email;
        this.Nombre = Nombre;
        this.apellido = apellido;
        this.Domicilio = Domicilio;
    }
}
