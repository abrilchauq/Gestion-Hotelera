namespace Proyecto;

    public class Habitacion
    {
        public int numHabitacion { get; private set; }
        public string tipoHabitacion { get; private set; }
        public double precioReserva { get; private set; }
        public bool disponibilidad { get; private set; }

        public Habitacion(int numHabitacion, string tipoHabitacion, double precioReserva, bool disponibilidad)
        {
            this.numHabitacion = numHabitacion;
            this.tipoHabitacion = tipoHabitacion;
            this.precioReserva = precioReserva;
            this.disponibilidad = disponibilidad;
        }
    }
