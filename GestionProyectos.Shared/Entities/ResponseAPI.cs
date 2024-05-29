using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectos.Shared.Entities
{
    public class ResponseAPI<T>
    {
        public bool Success { get; set; }
        public T? Valor { get; set; }
        public string? Mensaje { get; set; }
    }
}
