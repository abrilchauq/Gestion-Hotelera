using Proyecto.Entidades.Unidades;

namespace Proyecto.Entidades.Usuarios;

public class Mozo : Usuario
{
    public Guid IdMozo { get; private set; }
    public Mozo(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.IdMozo = Guid.NewGuid();
    }

    public void agregarRegistro(Habitacion habitacion)
    {

    }
}
