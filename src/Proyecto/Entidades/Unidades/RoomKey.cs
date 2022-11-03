namespace Proyecto.Entidades.Unidades;

public class RoomKey
{
    public Guid IdLlave { get; private set; }
    public string Codigo { get; private set; }

    public RoomKey(Guid IdLlave, string Codigo)
    {
        this.IdLlave = Guid.NewGuid();
        this.Codigo = Codigo;
    }
}
