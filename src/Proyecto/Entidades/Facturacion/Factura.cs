using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Facturacion;

[Table("Factura")]
public class Factura
{
    [Key]
    [Required]
    public Guid IdFactura { get; private set; }
    [Required]
    public int numero { get; private set; }
    [Required]
    public DateTime fechaHora { get; private set; }
    [Required]
    public double monto { get; private set; }
    [Required]
    public List<ItemFactura> Items { get; private set; }
    public Factura(int numero, DateTime fechaHora, double monto)
    {
        this.numero = numero;
        this.fechaHora = fechaHora;
        this.monto = monto;
        this.IdFactura = Guid.NewGuid();
        this.Items = new List<ItemFactura>();
    }

    public void agregarItemFactura(ItemFactura item)
    {
        Items.Add(item);
    }

    public void Actualizar(int numero, DateTime fechaHora, double monto)
    {
        this.numero = numero;
        this.fechaHora = fechaHora;
        this.monto = monto;
    }
}
