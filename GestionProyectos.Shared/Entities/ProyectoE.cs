using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class ProyectoE
    {
        public int ProyectoId { get; set; }

        public int? AdministradorId { get; set; }

        public string? Nombre { get; set; }

        public string? Tipo { get; set; }

        public string? Descripcion { get; set; }

        public DateOnly? FechaCreacion { get; set; }

        public int? Estado { get; set; }
    }
}
