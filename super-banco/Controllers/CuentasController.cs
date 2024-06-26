using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using super_banco.Extensions;
using SuperBanco.DAL;
using SuperBanco.DAL.Repositories;
using SuperBanco.Model;

namespace SuperBanco.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CuentasController(ILogger<CuentasController> logger, IMovimientoRepository movimientoRepository) : SuperBancoBaseController
{
    [HttpGet(Name = "ConsultarMovimientos/{Iban}")]
    public async Task<IEnumerable<Movimiento>> Consultar([FromQuery] string iban)
    {
        return await movimientoRepository.ObtenerMovimientos(iban, GetUserId());
    }
}
