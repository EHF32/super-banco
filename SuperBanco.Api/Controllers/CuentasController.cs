using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using super_banco.Extensions;
using SuperBanco.DAL;
using SuperBanco.DAL.Repositories.Interfaces;
using SuperBanco.Model;

namespace SuperBanco.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CuentasController(ILogger<CuentasController> logger, IMovimientoRepository movimientoRepository) : SuperBancoBaseController
{
    [HttpGet("ConsultarMovimientos/{iban}")]
    public async Task<IEnumerable<Movimiento>> Consultar(string iban)
    {
        return await movimientoRepository.ObtenerMovimientos(iban, GetUserId());
    }
}
