using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using super_banco.Extensions;
using SuperBanco.DAL;
using SuperBanco.Model;

namespace super_banco.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class CuentasController(ILogger<CuentasController> logger, SuperBancoDbContext superBancoDb) : ControllerBase
{ 
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<Cuenta>> Consultar()
    {
        var a = HttpContext.GetUserId();

        return await superBancoDb.Cuentas.ToListAsync();
    }
}
