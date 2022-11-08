namespace Proyecto.Entidades.Unidades;

public class Llave
{
    public Guid IdLlave { get; private set; }
    public string? Codigo { get; private set; }

    public Llave(string codigo)
    {
        this.Codigo = codigo;
        this.IdLlave = Guid.NewGuid();
    }
}
