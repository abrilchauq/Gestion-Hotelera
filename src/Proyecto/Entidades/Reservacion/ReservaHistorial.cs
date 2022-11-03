using Proyecto.Entidades.Usuarios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Reservacion;

public class ReservaHistorial
{
    public Guid IdReservaHistorial { get; private set; }
    public eTipoHabitacion Tipo { get; private set; }
    public List<Huesped> Huespedes { get; private set; }
    public DateTime FechaReserva { get; private set; }

    public ReservaHistorial(eTipoHabitacion tipo, DateTime fechaReserva)
    {
        this.Tipo = tipo;
        this.FechaReserva = fechaReserva;
        this.Huespedes = new List<Huesped>();
        this.IdReservaHistorial = Guid.NewGuid();
    }
}