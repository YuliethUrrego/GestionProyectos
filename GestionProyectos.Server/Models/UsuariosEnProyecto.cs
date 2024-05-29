using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class UsuariosEnProyecto
{
    public int UsuarioEnProyectoId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ProyectoId { get; set; }

    public DateOnly? Fecha { get; set; }

    public virtual Proyecto? Proyecto { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
