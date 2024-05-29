using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class Tarea
{
    public int TareaId { get; set; }

    public int? ProyectoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public int? Estado { get; set; }

    public string? Notas { get; set; }

    public DateOnly? FechaModificacion { get; set; }

    public virtual ICollection<Informe> Informes { get; set; } = new List<Informe>();

    public virtual Proyecto? Proyecto { get; set; }
}
