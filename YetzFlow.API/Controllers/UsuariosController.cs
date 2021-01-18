using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using YetzFlow.Core;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YetzFlow.API.Controllers
{
    Route("api/controller]")]
    ApiController]
    public class UsuariosController : ControllerBase
    {
        private IConfiguration configuration;
        private string connString;

        public UsuariosController(IConfiguration _configuration)
        {
            configuration = _configuration;
            connString = this.configuration.GetConnectionString("DefaultConnection");
        }

        HttpGet("{email}")]
        public ActionResult<Entity.Usuario> Get(string email, string senha)
        {
            try
            {
                if (string.IsNullOrEmpty(email)|| !email.IsEmailValid())
                {
                    return BadRequest("Digite um e-mail válido");
                }

                if (string.IsNullOrEmpty(senha))
                {
                    return BadRequest("Digite uma senha válida");
                }

                var usuario = new Core.Usuario(connString).Login(email, senha);

                if (usuario == null)
                    return NotFound();

                return Ok(usuario.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }

        HttpPut("{email}")]
        public ActionResult<Entity.Usuario> Put(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || !email.IsEmailValid())
                {
                    return BadRequest("Digite um e-mail válido");
                }

                var usuario = new Core.Usuario(connString).NewPassowrd(email);

                if (usuario == null)
                    return NotFound();

                return Ok(usuario.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }

    }
}
