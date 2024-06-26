using Microsoft.Extensions.DependencyInjection;
using SuperBanco.DAL.Repositories;
using SuperBanco.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBanco.DAL;

public static class DependencyInjection
{
    public static void AddSuperBancoDAL(this IServiceCollection services)
    {
        services.AddDbContext<SuperBancoDbContext>();

        services.AddScoped<IMovimientoRepository, MovimientoRepository>();
        services.AddScoped<ITarjetaRepository, TarjetaRepository>(); 
        services.AddScoped<ICajeroRepository, CajeroRepository>();
        //services.AddScoped<ICuentaRepository, CuentaRepository>();
    }

}
