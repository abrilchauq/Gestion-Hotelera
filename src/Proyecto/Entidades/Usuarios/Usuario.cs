using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;

public class Usuario
{
    public Guid IdUsuario { get; private set; }
    public string Nombre { get; private set; }
    public string Contraseña { get; private set; }
    public eEstadoUsuario Estado { get; private set; }

    public Usuario(string nombre, string contraseña, eEstadoUsuario estado)
    {
        this.Nombre = nombre;
        this.Contraseña = contraseña;
        this.Estado = estado;
        this.IdUsuario = Guid.NewGuid();
    }
}
