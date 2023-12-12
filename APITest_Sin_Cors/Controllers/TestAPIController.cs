using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITest_Sin_Cors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {

        ResultadoModel resultadoModel = new ResultadoModel();

        [HttpGet] 
        public IActionResult Get() {

            resultadoModel.detaill = "api funcionando correctamente";
            return Ok(resultadoModel);

        }

    }
}
