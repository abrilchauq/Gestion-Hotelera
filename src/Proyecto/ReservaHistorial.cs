namespace Proyecto;

    public class ReservaHistorial
    {
        public string tipoHabitacion { get; private set; }
        public List<Huesped> huespedes { get; private set; }
        public DateTime fechaReserva { get; private set; }
        
        public ReservaHistorial(string tipoHabitacion, DateTime fechaReserva)
        {
            this.tipoHabitacion = tipoHabitacion;
            this.huespedes = new List<Huesped>();
            this.fechaReserva = fechaReserva;
        }
    }