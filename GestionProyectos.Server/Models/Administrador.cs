using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class Administrador
{
    public int AdministradorId { get; set; }

    public int? PersonaId { get; set; }

    public int? Nit { get; set; }

    public string? RazonSocial { get; set; }

    public string? Telefono { get; set; }

    public string? EmailEmpresa { get; set; }

    public virtual Persona? Persona { get; set; }

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();
}
