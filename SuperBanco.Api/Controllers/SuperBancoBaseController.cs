using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using super_banco.Extensions;

namespace SuperBanco.Api.Controllers;

/// <summary>
/// Nuestro controlador base para SuperBanco que incluye la l�gica de
/// autenticaci�n y autorizaci�n
/// </summary>
[Authorize] 
public class SuperBancoBaseController : ControllerBase
{
    protected string GetUserId() => HttpContext.GetUserId(); 
}
