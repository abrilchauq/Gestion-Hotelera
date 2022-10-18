namespace Proyecto;
public class Cuenta
{
    public string Huesped { get; private set; }
    public string Habitaciones { get; private set; }
    public string tipoCuenta { get; private set; }

    public Cuenta(string Huesped, string Habitaciones, string tipoCuenta)
    {
        this.Huesped = Huesped;
        this.Habitaciones = Habitaciones;
        this.tipoCuenta = tipoCuenta;

    }
}