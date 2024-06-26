﻿using Microsoft.EntityFrameworkCore;
using SuperBanco.DAL.Repositories.Interfaces;
using SuperBanco.Model;

namespace SuperBanco.DAL.Repositories;

public class MovimientoRepository(SuperBancoDbContext db) : IMovimientoRepository
{ 
    public async Task<IEnumerable<Movimiento>> ObtenerMovimientos(string iban, string usuarioId)
    { 
        bool esSuCuenta = await db.Cuentas.Where(c => c.UsuarioId == usuarioId).AnyAsync(c => c.IBAN == iban);


        var a = await db.Cuentas.ToListAsync();

        if (!esSuCuenta) throw new Exception("No tiene permisos para ver los movimientos de esta cuenta.");

        return await db.Cuentas
          .Where(c => c.UsuarioId == usuarioId)
          .Where(c => c.IBAN == iban)
          .SelectMany(c => c.Movimientos)
          .ToListAsync();
    }

}
