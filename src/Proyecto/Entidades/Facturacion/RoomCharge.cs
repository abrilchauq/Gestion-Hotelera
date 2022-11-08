using Proyecto.Entidades.Servicios;

namespace Proyecto.Entidades.Facturacion;

public class RoomCharge
{
    public Guid IdRoomCharge { get; private set; }
    public DateTime fecha { get; private set; }
    public int duracion { get; private set; }

    public RoomCharge(DateTime fecha, int duracion)
    {
        this.fecha = fecha;
        this.duracion = duracion;
    }

    public void agregarItemFactura()
    {
        
    }
}