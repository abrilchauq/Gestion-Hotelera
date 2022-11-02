namespace Proyecto.Entidades;

public class Usuario
{
    public Guid IdUsuario { get; private set; }
    public string email { get; private set; }
    public string nombre { get; private set; }
    public string apellido { get; private set; }
    public string domicilio { get; private set; }

    public Usuario(string email, string nombre, string apellido, string domicilio)
    {
        this.email = email;
        this.nombre = nombre;
        this.apellido = apellido;
        this.domicilio = domicilio;
        this.IdUsuario = Guid.NewGuid();
    }
}
