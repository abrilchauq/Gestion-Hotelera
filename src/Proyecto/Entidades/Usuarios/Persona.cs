using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proyecto.Enums;

namespace Proyecto.Entidades.Usuarios;
[Table("Persona")]
public abstract class Persona
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [StringLength(50)]
    public string Email { get; set; }
    [StringLength(50)]
    public string Nombre { get; set; }
    [StringLength(50)]
    public string apellido { get; set; }
    [StringLength(50)]
    public string Telefono { get; set; }
    [StringLength(50)]
    public string Domicilio { get; set; }
    public eTipoUsuario Tipo { get; set; }
    public Usuario? Usuario { get; set; }

    public Persona(string email, string nombre, string apellido, string telefono, string domicilio, eTipoUsuario tipo)
    {
        this.id = Guid.NewGuid();
        this.Email = email;
        this.Nombre = nombre;
        this.apellido = apellido;
        this.Telefono = telefono;
        this.Domicilio = domicilio;
        this.Tipo = tipo;
    }

    public void AsignarUsuario(Usuario usuario) => this.Usuario = usuario;
}
