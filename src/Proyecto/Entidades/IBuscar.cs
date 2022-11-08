using Proyecto.Enums;

namespace Proyecto.Entidades;
public interface IBuscar
{
    void buscarHabitacion(eTipoEstilo estilo, DateTime fechaInicio, int duracionDias);
}