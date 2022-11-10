namespace Proyecto.Entidades.Facturacion;
public class Factura
{
    public Guid IdFactura { get; private set; }
    public int numero { get; private set; }
    public DateTime fechaHora { get; private set; }
    public double monto { get; private set; }
    public List<ItemFactura> Items { get; private set; }
    public Factura(Guid IdFactura)
    {
        this.IdFactura = Guid.NewGuid();
        this.Items = new List<ItemFactura>();
    }
}
