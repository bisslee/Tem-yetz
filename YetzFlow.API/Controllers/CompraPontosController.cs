using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace YetzFlow.API.Controllers
{
    Route("api/controller]")]
    ApiController]
    public class CompraPontosController : ControllerBase
    {
        private IConfiguration configuration;
        private string connString;

        public CompraPontosController(IConfiguration _configuration)
        {
            configuration = _configuration;
            connString = this.configuration.GetConnectionString("DefaultConnection");
        }

        HttpGet("{id}")]
        public ActionResult<Entity.CompraPonto> GetId(int id)
        {
            try
            {
                var entity = new Core.CompraPonto(connString).GetId(id);

                if (entity == null)
                    return NotFound();

                return Ok(entity.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }

        HttpGet]
        public ActionResult<List<Entity.CompraPonto>> GetAll()
        {
            try
            {
                var entity = new Core.CompraPonto(connString).GetAll();

                if (entity == null)
                    return NotFound();

                return Ok(entity.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }


        HttpPost]
        public ActionResult<List<Entity.CompraPonto>> Post(Entity.CompraPonto entity)
        {
            try
            {

                if (entity == null)
                {
                    return BadRequest();
                }

                var entityNovo = new Core.CompraPonto(connString).Save(entity);

                if (entityNovo == null)
                    return NotFound();

                return Ok(entityNovo.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }

        HttpPut("{id}")]
        public ActionResult<List<Entity.CompraPonto>> Put(int id, Entity.CompraPonto entity)
        {
            try
            {
                if (entity == null)
                {
                    return BadRequest();
                }

                var entityAtualizado = new Core.CompraPonto(connString).Update(entity);

                if (entityAtualizado == null)
                    return NotFound();

                return Ok(entityAtualizado.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }

        HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            try
            {
                var entity = new Core.CompraPonto(connString).Delete(id);

                if (entity == null)
                    return NotFound();

                return Ok(entity.Result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }
    }
}
