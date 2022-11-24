
namespace Presentacion.ViewModels;

public class RoomChargeViewModel
{
    public DateTime fecha { get; set; }
    public int duracion { get; private set; }
    public string descripcion { get; private set; }
    public double monto { get; set; }
}
