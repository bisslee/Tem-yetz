using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YetzFlow.API.Controllers
{
    Route("api/controller]")]
    ApiController]
    public class CampanhasController : ControllerBase
    {
        private IConfiguration configuration;
        private string connString;

        public CampanhasController(IConfiguration _configuration)
        {
            configuration = _configuration;
            connString = this.configuration.GetConnectionString("DefaultConnection");
        }

        HttpGet("{id}")]
        public ActionResult<Entity.Campanha> GetId(int id)
        {
            try
            {
                var entity = new Core.Campanha(connString).GetId(id);

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
        public ActionResult<List<Entity.Campanha>> GetAll()
        {
            try
            {
                var entity = new Core.Campanha(connString).GetAll();

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
        public ActionResult<List<Entity.Campanha>> Post(Entity.Campanha entity)
        {
            try
            {
                if (entity == null)
                {
                    return BadRequest();
                }

                var entityNovo = new Core.Campanha(connString).Save(entity);

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
        public ActionResult<List<Entity.Campanha>> Put(int id, Entity.Campanha entity)
        {
            try
            {

                if (entity == null)
                {
                    return BadRequest();
                }

                var entityAtualizado = new Core.Campanha(connString).Update(entity);

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
                var entity = new Core.Campanha(connString).Delete(id);

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
