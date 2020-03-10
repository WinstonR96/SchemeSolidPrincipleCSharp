using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;
using GeneradorDeVentas.Helpers;
using Serilog;
using System;

namespace GeneradorDeVentas.Resolvers
{
    public class GkResolver : IVentaService
    {
        private readonly ILogger log = LoggerApp.Instance.GetLogger.ForContext<GkResolver>();
        public T GenerarVenta<T>()
        {
            log.Information("Generando venta de GK");
            VentaGkModel venta = new VentaGkModel() { cliente = "Redsis" };
            return (T)Convert.ChangeType(venta, typeof(T));
        }
    }
}
