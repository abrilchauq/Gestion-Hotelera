namespace Proyecto;

public class ServicioHotel
{
    public Guid IdServiciosHotal { get; private set; }
    public double Precio { get; private set; }
    public DateTime FechaHora { get; private set; }

    public ServicioHotel(double Precio, DateTime FechaHora)
    {
        this.Precio = Precio;
        this.FechaHora = FechaHora;
        this.IdServiciosHotal = Guid.NewGuid();
    }
}
