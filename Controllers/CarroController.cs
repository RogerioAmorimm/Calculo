using System.Collections.Generic;
using System.Linq;
using ApiCalculo.Models;
using ApiCalculo.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace ApiCalculo.Controllers
{
    [ApiController]
    [Route("v1/carro")]
    public class TodoController : ControllerBase
    {
        [HttpPost]
        [Route("")]

        public ActionResult<Carro> Post([FromServices] ICarro handler, [FromBody] Carro carro)
        {
            try
            {
                if(!ModelState.IsValid) return BadRequest(ModelState);
                handler.Add(carro);
                return carro;

            }
            catch (System.Exception)
            {
                return BadRequest(new { message = "Não foi possível adicionar carro" });
            }
        }


        [HttpPut]
        [Route("{id:int}")]
        public ActionResult<Carro> Update([FromBody] Carro carro, [FromServices] ICarro handler, int id)
        {
            try
            {
                if(!ModelState.IsValid) return BadRequest(ModelState);
                
                if(carro.Id!=id) return NotFound(new {message=" Carro não encontrado"});
                
                handler.Update(carro);

                return carro;

            }
            catch (System.Exception)
            {
                return BadRequest(new { message = "Não foi possível atualizar carro" });
            }
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Carro>> GetALl([FromServices] ICarro handler)
        {
            try
            {
                var carros = handler.GetAll();

                return carros.ToList();

            }
            catch (System.Exception)
            {
                return BadRequest(new { message = "Não foi possível obter carros" });
            }

        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Carro> GetAllDone([FromServices] ICarro handle, int id)
        {
            try
            {
                var carro = handle.GetById(id);

                return carro;

            }
            catch (System.Exception)
            {
                return BadRequest(new { message = "Não foi possível obter carro" });
            }
        }
      }
}
