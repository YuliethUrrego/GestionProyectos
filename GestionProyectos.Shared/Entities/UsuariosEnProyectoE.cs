using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class UsuariosEnProyectoE
    {
        public int UsuarioEnProyectoId { get; set; }

        public int? UsuarioId { get; set; }

        public int? ProyectoId { get; set; }

        public DateOnly? Fecha { get; set; }

        public ProyectoE? Proyecto { get; set; }

        public UsuarioE? Usuario { get; set; }
    }
}
