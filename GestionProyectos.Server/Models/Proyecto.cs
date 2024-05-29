using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class Proyecto
{
    public int ProyectoId { get; set; }

    public int? AdministradorId { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public int? Estado { get; set; }

    public virtual Administrador? Administrador { get; set; }

    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();

    public virtual ICollection<UsuariosEnProyecto> UsuariosEnProyectos { get; set; } = new List<UsuariosEnProyecto>();
}
