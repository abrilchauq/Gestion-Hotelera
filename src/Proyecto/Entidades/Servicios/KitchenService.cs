using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Entidades.Servicios
{
    public class KitchenService
    {
        public string? descripcion { get; private set; }

        public KitchenService(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}