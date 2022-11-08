namespace Proyecto.Entidades.Facturacion;
public class ItemFactura
{
    public Guid IdItemFactura { get; set; }
    public double Monto { get; set; }

    public ItemFactura(double monto)
    {
        this.Monto = monto;
        this.IdItemFactura = Guid.NewGuid();
    }
}