namespace super_banco.Extensions;

public static class HttpContextExtensions
{
    /// <summary>
    /// Clase para extraer del HttpContext el usuario autenticado y separarlo del nombre del dominio
    /// </summary>
    public static string GetUserId(this HttpContext httpContext)
    {
        if (httpContext.User?.Identity?.Name == null)
        {
            throw new Exception("No hay usuario autenticado");
        }

        var user = httpContext.User;
        var domain = user.Identity.Name.Split("\\")[0];
        var username = user.Identity.Name.Split("\\")[1];

        return username;
    }

}
