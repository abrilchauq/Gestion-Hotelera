using Proyecto.Entidades.Usuarios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Reservacion;
public class Reserva
{
    public Guid IdReserva { get; private set; }
    public bool Estado { get; private set; } = false;
    public DateTime FechaReserva { get; private set; }
    public DateTime FechaHospedaje { get; private set; }
    public eTipoHabitacion Tipo { get; private set; }
    public List<Huesped> Huespedes { get; private set; }
    public Reserva(eTipoHabitacion tipo, DateTime fechaReserva, DateTime fechaHospedaje, string tipoHabitacion)
    {
        this.Tipo = tipo;
        this.FechaReserva = fechaReserva;
        this.FechaHospedaje = fechaHospedaje;
        this.Huespedes = new List<Huesped>();
        this.IdReserva = Guid.NewGuid();
    }
}
