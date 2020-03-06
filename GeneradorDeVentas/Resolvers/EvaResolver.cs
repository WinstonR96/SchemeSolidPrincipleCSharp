using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;
using System;

namespace GeneradorDeVentas.Resolvers
{
    public class EvaResolver : IVentaService
    {
        private string logFile;
        private DateTime dateTime;

        public EvaResolver()
        {
            this.logFile = Utils.Configuracion()["Logging:LogFile"];
            this.dateTime = DateTime.Now;
        }

        public T GenerarVenta<T>()
        {
            Console.WriteLine("Generando venta de EVA");
            Console.WriteLine("----------------------");
            Utils.WriteToLog(logFile, $"{dateTime} - Generando venta");
            VentaEvaModel venta = new VentaEvaModel() { Nro = 1 };
            return (T)Convert.ChangeType(venta, typeof(T));
        }
    }
}
