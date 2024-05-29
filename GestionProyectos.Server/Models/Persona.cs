using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class Persona
{
    public int PersonaId { get; set; }

    public string? Nombre { get; set; }

    public int? TipoIdentificacion { get; set; }

    public int? Cedula { get; set; }

    public string? Email { get; set; }

    public string? Contrasenia { get; set; }

    public virtual ICollection<Administrador> Administradors { get; set; } = new List<Administrador>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
