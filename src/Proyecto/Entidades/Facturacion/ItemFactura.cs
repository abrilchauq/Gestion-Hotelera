using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Facturacion;

[Table("ItemaFactura")]
public class ItemFactura
{
    [Key]
    [Required]
    public Guid IdItemFactura { get; set; }
    [Required]
    [StringLength(50)]
    public string Descripcion { get; set; }
    [Required]
    public double Monto { get; set; }
    [Required]
    public DateTime Fecha { get; set; }

    public ItemFactura(string descripcion, DateTime fecha, double monto)
    {
        this.Descripcion = descripcion;
        this.Fecha = fecha;
        this.Monto = monto;
        this.IdItemFactura = Guid.NewGuid();
    }
    public void Actualizar(string Descripcion, double Monto, DateTime Fecha)
    {
        this.Descripcion = Descripcion;
        this.Monto = Monto;
        this.Fecha = Fecha;
    }
}