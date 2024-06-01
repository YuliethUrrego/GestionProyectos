using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class AdministradorE
    {
        public int AdministradorId { get; set; }

        public int? PersonaId { get; set; }

        public int? Nit { get; set; }

        public string? RazonSocial { get; set; }

        public string? Telefono { get; set; }

        public string? EmailEmpresa { get; set; } 

        public PersonaE? Persona { get; set; }
    }
}
