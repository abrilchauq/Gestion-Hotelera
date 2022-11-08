using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

public abstract class Persona
{
    public string Email { get; private set; }
    public string Nombre { get; private set; }
    public string Telefono { get; private set; }
    public string Domicilio { get; private set; }
    public eTipoUsuario Tipo { get; set; }
    public Usuario? Usuario { get; set; }

    public Persona(string email, string nombre, string telefono, string domicilio, eTipoUsuario tipo)
    {
        this.Email = email;
        this.Nombre = nombre;
        this.Telefono = telefono;
        this.Domicilio = domicilio;
        this.Tipo = tipo;
    }

    public void AsignarUsuario(Usuario usuario) => this.Usuario = usuario;
}
