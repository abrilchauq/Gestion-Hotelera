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

    public Llave(int numero, string codigo)
    {
        this.IdLlave = Guid.NewGuid();
        this.numero = numero;
        this.codigo = codigo;
    }

    public void Actualizar(int numero, string codigo)
    {
        this.numero = numero;
        this.codigo = codigo;
    }
    public void Activo()
    {
        if (activo == false)
            activo = true;
    }
}
