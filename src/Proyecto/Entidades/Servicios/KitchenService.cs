using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Facturacion;

namespace Proyecto.Entidades.Servicios;
[Table("KitchenService")]
public class KitchenService : RoomCharge
{
    public KitchenService(string descripcion, DateTime fecha, int duracion) : base(fecha, duracion, descripcion)
    {
        this.monto = 1000;
    }

    public void Actualizar(string descripcion, DateTime fecha, int duracion)
    {
        this.descripcion = descripcion;
        this.fecha = fecha;
        this.duracion = duracion;
    }
}