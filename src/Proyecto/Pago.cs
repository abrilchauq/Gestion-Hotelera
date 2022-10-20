namespace Proyecto;
public class Pago
{
    public double Efectivo { get; private set; }
    public double Credito { get; private set; }
    public double Cheque { get; private set; }

    public Pago(double Efectivo, double Credito, double Cheque)
    {
        this.Efectivo = Efectivo;
        this.Credito = Credito;
        this.Cheque = Cheque;
    }
}