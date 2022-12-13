using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Facturacion;
[Table("RoomCharge")]
public class RoomCharge
{
    [Key]
    [Required]
    public Guid Id { get; protected set; }
    [Required]
    public DateTime fecha { get; protected set; }
    [Required]
    public int duracion { get; protected set; }
    [Required]
    [StringLength(50)]
    public string descripcion { get; protected set; }
    [Required]
    public double monto { get; set; }

    public RoomCharge(DateTime fecha, int duracion, string descripcion)
    {
        this.descripcion = descripcion;
        this.fecha = fecha;
        this.duracion = duracion;
    }

    public void agregarItemFactura(Factura factura)
    {
        var item = new ItemFactura(descripcion, fecha, monto);
        factura.agregarItemFactura(item);
    }

    public void Actualizar(DateTime fecha, int duracion, string descripcion, double monto)
    {
        this.fecha = fecha;
        this.duracion = duracion;
        this.descripcion = descripcion;
        this.monto = monto;
    }
}