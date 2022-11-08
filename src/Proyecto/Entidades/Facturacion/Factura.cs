namespace Proyecto.Entidades.Facturacion;
public class Factura
{
    public Guid IdFactura { get; private set; }
    public List<ItemFactura> Items { get; private set; }
    public Factura(Guid IdFactura)
    {
        this.IdFactura = Guid.NewGuid();
        this.Items = new List<ItemFactura>();
    }
}
