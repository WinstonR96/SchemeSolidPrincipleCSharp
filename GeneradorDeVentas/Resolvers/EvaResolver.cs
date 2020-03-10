using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;
using Serilog;
using System;

namespace GeneradorDeVentas.Resolvers
{
    public class EvaResolver : IVentaService
    {
        private readonly ILogger log = LoggerApp.Instance.GetLogger.ForContext<EvaResolver>();

        public T GenerarVenta<T>()
        {
            log.Information("Generando venta de EVA");
            VentaEvaModel venta = new VentaEvaModel() { Nro = 1 };
            return (T)Convert.ChangeType(venta, typeof(T));
        }
    }
}
