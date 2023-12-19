using Microsoft.AspNetCore.Mvc;

namespace webApiDollarEuroV1.Controllers
{
    [ApiController]
    [Route("api/divisas")]
    public class DivisasController : ControllerBase
    {
        [HttpGet("diferencia-tasa")]
        public ActionResult<object> GetDiferenciaTasa() 
        {
            decimal euroToDollarTasa = 1.10m;
            decimal dollarToEuroTasa = 1 / euroToDollarTasa;

            var diferenciaTasaResponse = new
            {
                EuroToDollarTasa = euroToDollarTasa,
                DollarToEuroTasa = dollarToEuroTasa
            };

            return Ok(diferenciaTasaResponse);
        }
    }
}
