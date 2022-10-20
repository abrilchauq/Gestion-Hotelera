namespace Proyecto
{
    public class Recepcionista : Usuario
    {
        public Recepcionista(string email, string nombre, string apellido
        , string domicilio)
            : base(email, nombre, apellido, domicilio)
            {

            }
        public void agregarHabitacion();
        public void crearReserva();
        public void cancelarReserva();
        public void checkIn();
        public void checkOut();
    }
}