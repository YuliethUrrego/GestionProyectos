using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class InformeE 
    {
        public int InformeId { get; set; }

        public int? TareaId { get; set; }

        public string? Nombre { get; set; }

        public string? TipoDoc { get; set; }

        public byte[]? Contenido { get; set; }
    }
}
