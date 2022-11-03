namespace Proyecto.Entidades.Servicios;

public class Comodidades : ServicioHotel
{
    public Guid IdComodidades { get; private set; }
    public Comodidades(double Precio, DateTime FechaHora)
        : base(Precio, FechaHora)
    {
        this.IdComodidades = Guid.NewGuid();
    }
}
