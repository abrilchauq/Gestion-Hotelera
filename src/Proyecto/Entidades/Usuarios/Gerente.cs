namespace Proyecto.Entidades.Usuarios;

public class Gerente : Usuario
{
    public Guid IdGerente { get; private set; }
    public Gerente(string email, string nombre, string apellido, string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.IdGerente = Guid.NewGuid();
    }

    public void registroCuenta()
    {

    }

    public void agregarEmpleado()
    {

    }
}
