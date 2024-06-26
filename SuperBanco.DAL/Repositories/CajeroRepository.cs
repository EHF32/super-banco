using Microsoft.EntityFrameworkCore;
using SuperBanco.DAL.Repositories.Interfaces;
using SuperBanco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBanco.DAL.Repositories;

/// <summary>
/// Repositorio de cajeros.
/// </summary>
public class CajeroRepository(SuperBancoDbContext db, ITarjetaRepository tarjetaRepository) : ICajeroRepository
{

    /// <summary>
    /// Obtiene un cajero por su ID.
    /// </summary>
    public async Task<Cajero> ObtenerCajeroPorId(int cajeroId)
    {
        var cajero = await db.Cajeros.FindAsync(cajeroId);

        return cajero ?? throw new Exception("No se encontró el cajero.");
    }

    /// <summary>
    /// Realiza una retirada de dinero en efectivo en un cajero.
    /// </summary>
    /// <returns></returns>
    public async Task<Movimiento> SacarDinero(string numeroTarjeta, int cajeroId, decimal cantidad)
    {
        var tarjeta = await tarjetaRepository.ObtenerTarjetaPorNumero(numeroTarjeta);
        var cajero = await ObtenerCajeroPorId(cajeroId);

        ValidarOperacion(tarjeta, cajero, cantidad);

        var comisiones = CalcularComisiones(cajero, cantidad);
        var totalMontoReal = cantidad + comisiones;

        ActualizarSaldoTarjeta(tarjeta, totalMontoReal);

        var movimiento = CrearRetiradaDeTarjeta(tarjeta, cajero, cantidad, comisiones);
        await db.SaveChangesAsync();

        return movimiento;
    }

    /// <summary>
    /// Valida si la operación de retirada de dinero es posible.
    /// </summary>
    /// <param name="tarjeta"></param>
    /// <param name="cajero"></param>
    /// <param name="cantidad"></param>
    /// <exception cref="Exception"></exception>
    private void ValidarOperacion(Tarjeta tarjeta, Cajero cajero, decimal cantidad)
    {
        if (tarjeta.Tipo == TipoTarjeta.Debito && tarjeta.Cuenta.Saldo < cantidad)
        {
            throw new Exception("No tiene suficiente saldo.");
        }
        else if (tarjeta.Tipo == TipoTarjeta.Credito && tarjeta.LimiteCredito < cantidad)
        {
            throw new Exception("No tiene suficiente crédito.");
        }
    }

    /// <summary>
    /// Actualiza el saldo de la tarjeta después de realizar una retirada de dinero.
    /// </summary>
    /// <param name="tarjeta"></param>
    /// <param name="totalMontoReal"></param>
    private void ActualizarSaldoTarjeta(Tarjeta tarjeta, decimal totalMontoReal)
    {
        if (tarjeta.Tipo == TipoTarjeta.Debito)
        {
            tarjeta.Cuenta.Saldo -= totalMontoReal;
        }
        else if (tarjeta.Tipo == TipoTarjeta.Credito)
        {
            tarjeta.LimiteCredito -= totalMontoReal;
        }
    }

    /// <summary>
    /// Crea un movimiento de retirada de dinero en efectivo.
    /// </summary>
    private Movimiento CrearRetiradaDeTarjeta(Tarjeta tarjeta, Cajero cajero, decimal cantidad, decimal comisiones)
    {
        var movimiento = new Movimiento
        {
            Tipo = TipoOperacion.Retirada,
            Fecha = DateTime.Now,
            Monto = cantidad,
            Descripcion = $"Retiro de efectivo en el cajero ubicado en {cajero.Ubicacion}",
            CajeroID = cajero.CajeroId,
            Comision = comisiones,
            TarjetaID = tarjeta.TarjetaId,
        };

        db.Add(movimiento);
        return movimiento;
    }

    /// <summary>
    /// Calcula las comisiones que aplican a una retirada de dinero en efectivo.
    /// </summary>
    private decimal CalcularComisiones(Cajero cajero, decimal cantidad)
    {
        ArgumentNullException.ThrowIfNull(cajero, nameof(cajero));

        return cajero.EsExterno ? cajero.Comisiones.GetValueOrDefault() : 0;
    }

}
