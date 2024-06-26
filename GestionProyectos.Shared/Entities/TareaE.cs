﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class TareaE 
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TareaId { get; set; }
        public int? ProyectoId { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public DateOnly? FechaCreacion { get; set; }

        public int? Estado { get; set; }

        public string? Notas { get; set; }

        public DateOnly? FechaModificacion { get; set; }

        public ProyectoE? Proyecto { get; set; }

    }
}
