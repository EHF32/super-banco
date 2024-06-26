namespace SuperBanco.Model;

public class Cuenta
{
    public int Id { get; set; }
    public string UsuarioId { get; set; }
    public string IBAN { get; set; }
    public decimal Saldo { get; set; }

    public List<Movimiento> Movimientos { get; set; }

    public List<Tarjeta> Tarjetas { get; set; }
}
