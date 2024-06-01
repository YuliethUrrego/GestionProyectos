using GestionProyectos.Shared.Entities;

namespace GestionProyectos.Client.Services
{
    public interface IProyecto
    {
        Task<List<ProyectoE>> Lista();
    }
}
