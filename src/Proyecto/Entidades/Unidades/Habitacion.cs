using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Entidades.Facturacion;
using Proyecto.Entidades.Servicios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Unidades;
[Table("Habitacion")]

public class Habitacion
{
    [Key]
    [Required]
    public Guid IdHabitacion { get; private set; }
    [Required]
    public int Numero { get; private set; }
    [Required]
    public eTipoEstilo Tipo { get; private set; }
    [Required]
    public double PrecioReserva { get; private set; }
    [Required]
    public eEstadoHabitacion Estado { get; private set; } = eEstadoHabitacion.NoDisponible;

    public Llave Llave { get; private set; }

    public List<ServicioLimpieza> ServicioLimpiezas { get; set; }
    public List<RoomCharge> RoomCharges { get; set; }

    public Habitacion(int numero, eTipoEstilo tipo, double precioReserva, Llave llave)
    {
        this.Numero = numero;
        this.Tipo = tipo;
        this.PrecioReserva = precioReserva;
        this.IdHabitacion = Guid.NewGuid();
        this.ServicioLimpiezas = new List<ServicioLimpieza>();
        this.RoomCharges = new List<RoomCharge>();
        this.Llave = llave;
    }
    public Habitacion()
    {
        this.ServicioLimpiezas = new List<ServicioLimpieza>();
        this.RoomCharges = new List<RoomCharge>();
    }

    public void Liberar()
    {
        Estado = eEstadoHabitacion.Disponible;
    }

    public void AgregarServicioLimpieza(ServicioLimpieza servicioLimpieza)
    {
        this.ServicioLimpiezas.Add(servicioLimpieza);
    }

    public void agregarRoomCharge(RoomCharge roomCharge) => RoomCharges.Add(roomCharge);

    public void Actualizar(int numero, int tipo, double precioReserva)
    {
        this.Numero = numero;
        this.Tipo = (eTipoEstilo)tipo;
        this.PrecioReserva = precioReserva;
    }


}
