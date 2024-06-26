using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using super_banco.Extensions;
using SuperBanco.DAL;

namespace super_banco.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CuentasController(ILogger<CuentasController> logger, SuperBancoDbContext superBancoDb) : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<Cuenta>> Get()
        {
            var a = HttpContext.GetUserId();

            return await superBancoDb.Cuentas.ToListAsync();
        }
    }
}
