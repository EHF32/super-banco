using SuperBanco.Model;

namespace SuperBanco.DAL.Repositories.Interfaces;

public interface ICajeroRepository
{
    Task<Cajero> ObtenerCajeroPorId(int cajeroId);
    Task<Movimiento> SacarDinero(string numeroTarjeta, int cajeroId, decimal cantidad);
}