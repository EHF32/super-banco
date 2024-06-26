using Microsoft.EntityFrameworkCore;
using SuperBanco.DAL.Repositories.Interfaces;
using SuperBanco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBanco.DAL.Repositories;

public class TarjetaRepository(SuperBancoDbContext db) : ITarjetaRepository
{
    /// <summary>
    /// Obtiene una tarjeta por su número.
    /// </summary>
    public async Task<Tarjeta> ObtenerTarjetaPorNumero(string numeroTarjeta)
    {
        var tarjeta = await db.Tarjetas.Include(t => t.Cuenta).FirstOrDefaultAsync(t => t.Numero == numeroTarjeta);

        return tarjeta ?? throw new Exception("No se encontró la tarjeta.");
    }
}
