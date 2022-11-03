namespace Proyecto.Entidades;
public class Factura
{
    public Guid IdFactura { get; private set; }
    public string Nombre { get; private set; }
    public string Domicilio { get; private set; }
    public double Total { get; private set; }
    public double CargoHabitacion { get; private set; }
    public Factura(Guid IdFactura, string Nombre, string Domicilio, double Total, double CargoHabitacion)
    {
        this.IdFactura = Guid.NewGuid();
        this.Nombre = Nombre;
        this.Domicilio = Domicilio;
        this.Total = Total;
        this.CargoHabitacion = CargoHabitacion;
    }
}
