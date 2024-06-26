using SuperBanco.Model;

namespace SuperBanco.DAL.Repositories.Interfaces;

public interface ITarjetaRepository
{
    Task<Tarjeta> ObtenerTarjetaPorNumero(string numeroTarjeta);
}