using Proyecto.Enums;

namespace Proyecto.Entidades.Unidades;

public class Habitacion
{
    public Guid IdHabitacion { get; private set; }
    public int Numero { get; private set; }
    public eTipoHabitacion Tipo { get; private set; }
    public double PrecioReserva { get; private set; }
    public bool Disponibilidad { get; private set; } = false;
    public RoomKey Llave { get; private set; }

    public Habitacion(int numero, eTipoHabitacion tipo, double precioReserva, bool disponibilidad, RoomKey llave)
    {
        this.Numero = numero;
        this.Tipo = tipo;
        this.PrecioReserva = precioReserva;
        this.Disponibilidad = disponibilidad;
        this.Llave = llave;
        this.IdHabitacion = Guid.NewGuid();
    }
}
