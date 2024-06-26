﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class UsuarioE 
    {
        public int UsuarioId { get; set; }

        public int? PersonaId { get; set; }

        public int? RolId { get; set; }

        public virtual PersonaE? Persona { get; set; }

        public virtual RolE? Rol { get; set; }
    }
}
