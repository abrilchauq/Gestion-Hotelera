using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Entidades.Unidades;
[Table("Llave")]
public class Llave
{
    [Key]
    [Required]
    public Guid IdLlave { get; private set; }
    [Required]
    public int numero { get; private set; }
    [Required]
    public string codigo { get; private set; }
    [Required]
    public bool activo { get; set; } = false;
    [Required]
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
        if (activo == false)
            activo = true;
    }
}
