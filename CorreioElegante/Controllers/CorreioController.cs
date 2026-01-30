using CorreioElegante.Dtos;
using CorreioElegante.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorreioElegante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorreioController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public CorreioController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Salvar")]
        public IActionResult Salvar([FromBody] SalvarCorreioDto salvarCorreioDto)
        { 
            var resultado = CorreioService.Salvar(salvarCorreioDto);
            return Ok(resultado);
        }
    }
}
