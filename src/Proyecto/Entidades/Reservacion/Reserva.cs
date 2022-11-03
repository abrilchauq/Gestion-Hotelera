using Proyecto.Entidades.Usuarios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Reservacion;
public class Reserva
{
    public Guid IdReserva { get; private set; }
    public eEstadoReserva Estado { get; private set; } = eEstadoReserva.Activa;
    public DateTime FechaReserva { get; private set; }
    public DateTime FechaHospedaje { get; private set; }
    public eTipoHabitacion Tipo { get; private set; }
    public List<Huesped> Huespedes { get; private set; }
    public Reserva(eTipoHabitacion tipo, DateTime fechaHospedaje, Huesped huesped)
    {
        this.Tipo = tipo;
        this.FechaReserva = DateTime.Now;
        this.FechaHospedaje = fechaHospedaje;
        this.Huespedes = new List<Huesped>();
        this.IdReserva = Guid.NewGuid();
        this.Huespedes.Add(huesped);
    }

    public void Cancelar()
    {
        Estado = eEstadoReserva.Cancelada;
    }

    public void Completada()
    {
        Estado = eEstadoReserva.Completada;
    }
}
