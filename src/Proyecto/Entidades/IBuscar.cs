using Proyecto.Entidades.Unidades;
using Proyecto.Enums;

namespace Proyecto.Entidades;
public interface IBuscar
{
    List<Habitacion> buscarHabitacion(eTipoEstilo estilo, DateTime fechaInicio, int duracionDias);
}