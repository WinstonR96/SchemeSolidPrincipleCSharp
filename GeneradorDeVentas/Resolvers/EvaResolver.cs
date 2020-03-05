using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;
using System;

namespace GeneradorDeVentas.Resolvers
{
    public class EvaResolver : IVentaService
    {
        public T GenerarVenta<T>()
        {
            VentaEvaModel venta = new VentaEvaModel() { Nro = 1 };
            return (T)Convert.ChangeType(venta, typeof(T));
        }
    }
}
