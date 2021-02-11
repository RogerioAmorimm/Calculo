using ApiCalculo.Models;
using ApiCalculo.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace ApiCalculo.Controllers
{
    [ApiController]
    [Route("v1/trip")]
    public class TripController : ControllerBase
    {
        [HttpPost]
        [Route("")]

        public ActionResult<TripResult> Post([FromServices] ICarro handler, [FromBody] Trip trip)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var carro = handler.GetById(trip.CarroID);

                if (carro == null) return NotFound(new { message = "Carro não encontrado" });


                return (TripResult)trip.CalcularTrip(carro);

            }
            catch (System.Exception)
            {
                return BadRequest(new { message = "Não foi possível calcular dados da viagem" });
            }
        }
    }
}
