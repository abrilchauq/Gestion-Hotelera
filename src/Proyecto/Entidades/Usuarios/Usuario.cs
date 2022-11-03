namespace Proyecto.Entidades.Usuarios;

public abstract class Usuario
{
    public Guid IdUsuario { get; private set; }
    public string Email { get; private set; }
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Domicilio { get; private set; }

    public Usuario(string email, string nombre, string apellido, string domicilio)
    {
        this.Email = email;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Domicilio = domicilio;
        this.IdUsuario = Guid.NewGuid();
    }
}
