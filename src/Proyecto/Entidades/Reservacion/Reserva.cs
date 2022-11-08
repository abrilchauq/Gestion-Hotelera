using Proyecto.Entidades.Usuarios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Reservacion;
public class Reserva
{
    public Guid IdReserva { get; private set; }
    public eEstadoReserva Estado { get; private set; } = eEstadoReserva.Activa;
    public DateTime FechaReserva { get; private set; }
    public DateTime FechaHospedaje { get; private set; }
    public eTipoEstilo Tipo { get; private set; }
    public Huesped Huesped { get; private set; }
    public Reserva(eTipoEstilo tipo, DateTime fechaHospedaje, Huesped huesped)
    {
        this.Tipo = tipo;
        this.FechaReserva = DateTime.Now;
        this.FechaHospedaje = fechaHospedaje;
        this.IdReserva = Guid.NewGuid();
        this.Huesped = huesped;
    }

    public void Cancelar()
    {
        Estado = eEstadoReserva.Cancelada;
    }

    public void Completada()
    {
        Estado = eEstadoReserva.Completada;
    }

    internal void CheckIn()
    {
        Estado = eEstadoReserva.Completada;
    }
}
