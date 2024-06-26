using SuperBanco.Model;

namespace SuperBanco.DAL.Repositories.Interfaces;

public interface IMovimientoRepository
{
    Task<IEnumerable<Movimiento>> ObtenerMovimientos(string iban, string usuarioId);
}