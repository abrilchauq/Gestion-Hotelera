namespace Proyecto.Entidades;

public class RoomKey
{
    public Guid IdLlave { get; private set; }
    public string Codigo { get; set; }

    public RoomKey(Guid IdLlave, string Codigo)
    {
        this.IdLlave = Guid.NewGuid();
        this.Codigo = Codigo;
    }
}
