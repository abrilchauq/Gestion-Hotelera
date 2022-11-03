using Proyecto.Entidades.Servicios;

namespace Proyecto.Entidades.Facturacion;

public class RoomCharge
{
    public Guid IdRoomCharge { get; private set; }
    public Comodidades? Comodidades { get; private set; }
    public ServicioHabitacion? ServicioHabitacion { get; private set; }
    public ServicioLimpieza? ServicioLimpieza { get; private set; }
    public Alimentos? Alimentos { get; private set; }
    public RegistroServicio? Registros { get; private set; }

    public RoomCharge()
    {
        this.IdRoomCharge = Guid.NewGuid();
    }
}