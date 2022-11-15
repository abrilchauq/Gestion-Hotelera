using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Facturacion;

namespace Proyecto.Entidades.Servicios;
[Table("RoomService")]
public class RoomService : RoomCharge
{
    [Required]
    public DateTime Solicitud { get; private set; }
    [Required]
    public bool SeCobra { get; private set; } = false;

    public RoomService(DateTime Solicitud, bool SeCobra, DateTime fecha, int duracion, string descripcion)
        : base(fecha, duracion, descripcion)
    {
        this.Solicitud = Solicitud;
        this.SeCobra = SeCobra;
        this.monto = 100;
    }
}
