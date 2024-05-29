using GestionProyectos.Shared.Entities;

namespace GestionProyectos.Client.Services
{
    public interface IUsuario
    {
        Task<List<UsuarioE>> Lista();
    }
}
