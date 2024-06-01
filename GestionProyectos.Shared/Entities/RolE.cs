using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class RolE 
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int RolId { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }
    }
}
