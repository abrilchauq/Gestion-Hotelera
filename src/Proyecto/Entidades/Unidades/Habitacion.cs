using Proyecto.Entidades.Servicios;
using Proyecto.Enums;

namespace Proyecto.Entidades.Unidades;

public class Habitacion
{
    public Guid IdHabitacion { get; private set; }
    public int Numero { get; private set; }
    public eTipoEstilo Tipo { get; private set; }
    public double PrecioReserva { get; private set; }
    public eEstadoHabitacion Estado { get; private set; } = eEstadoHabitacion.NoDisponible;
    public Llave Llave { get; private set; }
    public List<ServicioLimpieza> ServicioLimpiezas { get; set; }

    public Habitacion(int numero, eTipoEstilo tipo, double precioReserva, Llave llave)
    {
        this.Numero = numero;
        this.Tipo = tipo;
        this.PrecioReserva = precioReserva;
        this.IdHabitacion = Guid.NewGuid();
        this.ServicioLimpiezas = new List<ServicioLimpieza>();
        this.Llave = llave;
    }

    public void checkIn()
    {

    }

    public void checkOut()
    {

    }

    public void Liberar()
    {
        Estado = eEstadoHabitacion.Disponible;
    }

    public void AgregarServicioLimpieza(ServicioLimpieza servicioLimpieza)
    {
        this.ServicioLimpiezas.Add(servicioLimpieza);
    }

    public void AsignarLlave(Llave llave)
    {
        this.Llave = llave;
    }
}
