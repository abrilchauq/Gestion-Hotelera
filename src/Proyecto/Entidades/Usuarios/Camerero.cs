using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

public class Camarero : Persona
{
    public Guid IdCamarero { get; private set; }
    public Camarero(string email, string nombre, string telefono, string domicilio)
        : base(email, nombre, telefono, domicilio, eTipoUsuario.Camarero)
    {
        this.IdCamarero = Guid.NewGuid();
    }
}
