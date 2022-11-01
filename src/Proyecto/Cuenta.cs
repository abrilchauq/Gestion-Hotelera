namespace Proyecto;
public class Cuenta
{
    public Guid IdCuenta { get; private set; }
    public Huesped Huesped { get; private set; }
    public List<Habitacion> Habitaciones { get; private set; }
    public string tipoCuenta { get; private set; }

    public Cuenta(Huesped Huesped, string tipoCuenta)
    {
        this.Huesped = Huesped;
        this.Habitaciones = new List<Habitacion>();
        this.tipoCuenta = tipoCuenta;
        this.IdCuenta = Guid.NewGuid();
    }
}