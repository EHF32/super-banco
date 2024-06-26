namespace SuperBanco.Contracts;

public class RetiradaDeCajeroRequest
{
    /// <summary>
    /// Número de tarjeta.
    /// </summary>
    public string NumeroTarjeta { get; set; }

    /// <summary>
    /// Identificador del cajero.
    /// </summary>
    public int CajeroId { get; set; }

    /// <summary>
    /// Monto a retirar.
    /// </summary>
    public decimal Monto { get; set; } 
}
