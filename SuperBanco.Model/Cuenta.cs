namespace SuperBanco.Model;

public class Cuenta
{
    public int CuentaId { get; set; }
    public string UsuarioId { get; set; }
    public string IBAN { get; set; }
    public decimal Saldo { get; set; }

    public List<Movimiento> Movimientos { get; set; }

    public List<Tarjeta> Tarjetas { get; set; }
}
