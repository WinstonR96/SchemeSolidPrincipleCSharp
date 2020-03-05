using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;
using System;

namespace GeneradorDeVentas.Resolvers
{
    public class GkResolver : IVentaService
    {
        public T GenerarVenta<T>()
        {
            VentaGkModel venta = new VentaGkModel() { cliente = "Redsis" };
            return (T)Convert.ChangeType(venta, typeof(T));
        }
    }
}
