namespace Presentacion.ViewModels;

public class ItemFacturaViewModel
{
    public Guid IdItemFactura {get; set; }
    public string Descripcion { get; set; }
    public double Monto { get; set; }
    public DateTime Fecha { get; set; }
}
