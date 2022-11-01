namespace Proyecto;

public class Mozo : Usuario
{
    public Guid idMozo { get; private set; }
    public Mozo(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.idMozo = Guid.NewGuid();
    }

    public void agregarRegistro(Habitacion habitacion)
    {

    }
}
