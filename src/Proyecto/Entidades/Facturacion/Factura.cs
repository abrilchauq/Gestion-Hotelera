namespace Proyecto.Entidades.Facturacion;
public class Factura
{
    public Guid IdFactura { get; private set; }
    public List<RoomCharge> RoomCharges { get; private set; }
    public Factura(Guid IdFactura)
    {
        this.IdFactura = Guid.NewGuid();
        this.RoomCharges = new List<RoomCharge>();
    }
}
