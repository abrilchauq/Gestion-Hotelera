namespace Proyecto;
public class Factura
{
    public Guid Id { get; private set; }
    public string Nombre { get; private set; }
    public string Domicilio { get; private set; }
    public double Total { get; private set; }
    public double CargoHabitacion { get; private set; }

    public Factura(Guid Id, string Nombre, string Domicilio, double Total, double CargoHabitacion)
    {
        this.Id = Guid.NewGuid();
        this.Nombre = Nombre;
        this.Domicilio = Domicilio;
        this.Total = Total;
        this.CargoHabitacion = CargoHabitacion;
    }
}
