using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBanco.Model;

public class Movimiento
{

    public int MovimientoId { get; set; }
    public TipoOperacion Tipo { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Monto { get; set; }
    public string Descripcion { get; set; }
    public string CuentaDestinoIBAN { get; set; }
    public decimal? Comision { get; set; }

    public Tarjeta Tarjeta { get; set; }
    public int? TarjetaID { get; set; }

    public Cajero Cajero { get; set; }
    public int? CajeroID { get; set; }

    public int? CuentaId { get; set; }
    public Cuenta Cuenta { get; set; }
}
