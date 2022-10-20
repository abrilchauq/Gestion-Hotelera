namespace Proyecto;

    public class Gerente : Usuario
    {
        public Gerente(string email, string nombre, string apellido
        , string domicilio)
            : base(email, nombre, apellido, domicilio)
            {

            }

        public void registroCuenta();
        public void agregarEmpleado();
    }
