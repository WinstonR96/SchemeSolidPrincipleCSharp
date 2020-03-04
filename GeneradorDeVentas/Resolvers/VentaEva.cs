using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;

namespace GeneradorDeVentas.Resolvers
{
    public class VentaEva : IVentaService
    {
        public Venta GenerarVenta()
        {
            return new Venta() { Nro = 1 };
        }
    }
}
