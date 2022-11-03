namespace Proyecto.Entidades.Usuarios;

public class Invitado : Usuario
{
    public Guid idInvitado { get; private set; }
    public Invitado(string email, string nombre, string apellido
    , string domicilio)
        : base(email, nombre, apellido, domicilio)
    {
        this.idInvitado = Guid.NewGuid();
    }
}
