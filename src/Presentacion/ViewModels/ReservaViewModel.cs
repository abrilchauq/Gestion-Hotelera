namespace Presentacion.ViewModels;
public class ReservaViewModel
{
    public DateTime FechaReserva { get; set; }
    public DateTime FechaHospedaje { get; set; }
    public int Tipo { get; set; }
    public Guid IdHuesped { get; set; }
}
