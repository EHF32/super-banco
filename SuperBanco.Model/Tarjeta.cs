using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBanco.Model;

public class Tarjeta
{

    public int TarjetaId { get; set; } 
    public string Numero { get; set; }
    public DateTime FechaExpiracion { get; set; }
    public int CVV { get; set; }
    public TipoTarjeta Tipo { get; set; }
    public decimal LimiteCredito { get; set; }
    public bool EsActiva { get; set; }
    public string PIN { get; set; }

    public int CuentaId { get; set; }
    public Cuenta Cuenta { get; set; }

    public List<Movimiento> Movimientos { get; set; }
}

public enum TipoTarjeta
{
    Debito,
    Credito
}

