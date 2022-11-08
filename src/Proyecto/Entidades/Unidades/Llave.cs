namespace Proyecto.Entidades.Unidades;

public class Llave
{
    public Guid IdLlave { get; private set; }
    public int numero { get; private set; }
    public string codigo { get; private set; }
    public bool activo { get; set; } = false;
    public Habitacion habitacion { get; set; }

    public Llave(int numero, string codigo)
    {
        this.IdLlave = Guid.NewGuid();
        this.numero = numero;
        this.codigo = codigo;
    }

    public void AsignarHabitacion(Habitacion habitacion)
    {
        this.habitacion = habitacion;
    }

    public void Activo()
    {

    }
}
