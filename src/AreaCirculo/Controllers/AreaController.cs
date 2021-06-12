using AppService;
using Microsoft.AspNetCore.Mvc;

namespace AreaCirculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpGet]
        public double Circulo(double raio) => _areaService.CalcularAreaCirculo(raio);
    }
}
