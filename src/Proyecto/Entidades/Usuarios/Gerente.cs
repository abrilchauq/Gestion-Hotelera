using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

public class Gerente : Persona
{
    public Guid IdGerente { get; private set; }
    public Gerente(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio, eTipoUsuario.Gerente)
    {
        this.IdGerente = Guid.NewGuid();
    }

    public void agregarEmpleado()
    {

    }
}
