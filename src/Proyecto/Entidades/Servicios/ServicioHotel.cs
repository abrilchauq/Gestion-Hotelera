namespace Proyecto.Entidades.Servicios;

public abstract class ServicioHotel
{
    public Guid IdServicioHotal { get; private set; }
    public double Precio { get; private set; }
    public DateTime FechaHora { get; private set; }

    public ServicioHotel(double Precio, DateTime FechaHora)
    {
        this.Precio = Precio;
        this.FechaHora = FechaHora;
        this.IdServicioHotal = Guid.NewGuid();
    }
}
