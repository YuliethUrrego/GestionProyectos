using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public int? PersonaId { get; set; }

    public int? RolId { get; set; }

    public virtual Persona? Persona { get; set; }

    public virtual Rol? Rol { get; set; }

    public virtual ICollection<UsuariosEnProyecto> UsuariosEnProyectos { get; set; } = new List<UsuariosEnProyecto>();
}
