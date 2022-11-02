namespace Proyecto.Entidades;
public class Notificacion
{
    public Guid idNotificacion { get; private set; }
    public string notificacion { get; private set; }
    public Notificacion(string notificacion)
    {
        this.idNotificacion = Guid.NewGuid();
        this.notificacion = notificacion;
    }
}
