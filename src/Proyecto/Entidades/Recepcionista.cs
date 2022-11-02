namespace Proyecto.Entidades;
public class Recepcionista : Usuario
{
    public Guid idRecepcionista { get; private set; }
    public Recepcionista(string email, string nombre, string apellido
    , string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.idRecepcionista = Guid.NewGuid();
    }
    public void agregarHabitacion()
    {

    }

    public void crearReserva()
    { }

    public void cancelarReserva()
    { }

    public void checkIn()
    { }

    public void checkOut()
    { }
}