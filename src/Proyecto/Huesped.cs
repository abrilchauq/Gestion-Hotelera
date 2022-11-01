
namespace Proyecto;

public class Huesped : Usuario
{
    public Guid idHuesped { get; private set; }
    public Huesped(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.idHuesped = Guid.NewGuid();
    }
    public void Buscar(Habitacion habitacion)
    {
        
    }
    public void Reservar(Habitacion habitacion)
    {

    }
}
