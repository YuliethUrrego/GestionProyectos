using System;
using System.Collections.Generic;

namespace GestionProyectos.Server.Models;

public partial class Informe
{
    public int InformeId { get; set; }

    public int? TareaId { get; set; }

    public string? Nombre { get; set; }

    public string? TipoDoc { get; set; }

    public byte[]? Contenido { get; set; }

    public virtual Tarea? Tarea { get; set; }
}
