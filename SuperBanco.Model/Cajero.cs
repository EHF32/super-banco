using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBanco.Model;

public class Cajero
{
    public int CajeroId { get; set; }
    public string Ubicacion { get; set; }
    public bool EsExterno { get; set; } 
    public decimal? Comisiones { get; set; }

    public List<Movimiento> Movimientos { get; set; }
}
