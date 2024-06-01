using GestionProyectos.Server.Models;
using GestionProyectos.Shared;
using GestionProyectos.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionProyectos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase 
    {
        private readonly BdproyectoGestionContext _dbContext;

        public UsuarioController(BdproyectoGestionContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("ListarUsuarios")]
        public async Task<IActionResult> ListarUsuarios()
        {
            var responseApi = new ResponseAPI<List<UsuarioE>>();
            var listaUsuarios = new List<UsuarioE>();

            try
            {
                foreach (var bdUsuarios in await _dbContext.Usuarios.Include(x => x.Persona).ToListAsync())
                {
                    listaUsuarios.Add(new UsuarioE
                    {
                        UsuarioId = bdUsuarios.UsuarioId,
                        PersonaId = bdUsuarios.PersonaId,
                        Persona = new PersonaE
                        {
                            PersonaId = bdUsuarios.Persona.PersonaId,
                            Nombre = bdUsuarios.Persona.Nombre,
                            TipoIdentificacion = bdUsuarios.Persona.TipoIdentificacion,
                            Cedula = bdUsuarios.Persona.Cedula,
                            Email = bdUsuarios.Persona.Email,
                            Contrasenia = bdUsuarios.Persona.Contrasenia
                        }   
                    }
                    );
                }

                responseApi.Success = true;
                responseApi.Valor = listaUsuarios;
            }
            catch (Exception ex)
            {
                responseApi.Success = false;
                responseApi.Mensaje = ex.Message;
                throw;
            }
            return Ok(responseApi);

        }
    }
}
