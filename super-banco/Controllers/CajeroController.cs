using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using super_banco.Extensions;
using SuperBanco.Contracts;
using SuperBanco.DAL;
using SuperBanco.DAL.Repositories.Interfaces;
using SuperBanco.Model;

namespace SuperBanco.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CajeroController(ILogger<CuentasController> logger, ICajeroRepository cajeroRepository) : SuperBancoBaseController
{
    [HttpPost("/SacarDinero", Name = "Sacar dinero de un cajero")]
    public async Task<Movimiento> SacarDinero([FromBody] RetiradaDeCajeroRequest request)
    {
        return await cajeroRepository.SacarDinero(request.NumeroTarjeta, request.CajeroId, request.Monto);
    }

  /*  [HttpPost(Name = "Ingresar")]
    public async Task<Movimiento> Consultar([FromBody] IngresoEnCajeroRequest request)
    {
        return await cajeroRepository.IngresarDinero(request.NumeroTarjeta, request.CajeroId, request.Monto);
    }*/
}
