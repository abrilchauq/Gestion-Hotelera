namespace Proyecto;

public class Alimentos : ServicioHotel
{
    public Guid IdAlimentos { get; private set; }
    public Alimentos(double Precio, DateTime FechaHora)
        : base(Precio, FechaHora)
    {
        this.IdAlimentos = Guid.NewGuid();
    }
}
