using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Usuarios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Reservacion;
[Table("Reserva")]
public class Reserva
{
    [Key]
    [Required]
    public Guid IdReserva { get; private set; }
    [Required]
    public eEstadoReserva Estado { get; private set; } = eEstadoReserva.Activa;
    [Required]
    public DateTime FechaReserva { get; private set; }
    [Required]
    public DateTime FechaHospedaje { get; private set; }
    [Required]
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

    public Reserva()
    {

    }

    public void Actualizar(DateTime FechaReserva, DateTime FechaHospedaje, int Tipo)
    {
        this.FechaReserva = FechaReserva;
        this.FechaHospedaje = FechaHospedaje;
        this.Tipo = (eTipoEstilo)Tipo;
    }

    public void Cancelar()
    {
        Estado = eEstadoReserva.Cancelada;
    }

    public void Completada()
    {
        Estado = eEstadoReserva.Completada;
    }

    public void CheckIn()
    {
        Estado = eEstadoReserva.Completada;
    }
}
