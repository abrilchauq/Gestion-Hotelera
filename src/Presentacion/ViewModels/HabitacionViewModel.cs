
namespace Presentacion.ViewModels;

public class HabitacionViewModel : HabitacionModificarViewModel
{
    public string CodigoLlave { get; set; }
}

public class HabitacionModificarViewModel
{
    public int numero { get; set; }
    public int tipo { get; set; }
    public double precioReserva { get; set; }
}
