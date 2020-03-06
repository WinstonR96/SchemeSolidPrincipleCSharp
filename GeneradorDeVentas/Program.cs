using GeneradorDeVentas.Enums;
using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Models;
using GeneradorDeVentas.Resolvers;
using GeneradorDeVentas.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GeneradorDeVentas
{
    public class Program
    {
        private static string logFile;
        private static string url;
        private static string pos;
        static void Main(string[] args)
        {
            Configurar();
            procesarVentas();
            Console.ReadLine();
                                                                
        }

        private static void Configurar()
        {
            Console.WriteLine("Inicializando");
            Console.WriteLine("Obteniendo configuración.....");

            //Obteniendo configuración
            logFile = Utils.Configuracion()["Logging:LogFile"];
            url = Utils.Configuracion()["Endpoint"];
            pos = Utils.Configuracion()["Pos"].ToLower();
            var dateTime = DateTime.Now;

            Utils.WriteToLog(logFile, $"{dateTime} - Obteniendo configuración");
        }

        private static void procesarVentas()
        {
            switch (pos)
            {
                case "eva":
                    VentaEva();
                    break;
                case "gk":
                    VentaGk();
                    break;
            }            
        }

        private static void VentaGk()
        {
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("Generando venta de GK");
            var ventaGk = new VentaService<VentaGkModel>(new GkResolver());
            var dataGk = ventaGk.GenerarVenta<VentaGkModel>();
            Console.WriteLine("Cliente: {0}", dataGk.cliente);
            Console.ReadLine();
        }

        private static void VentaEva()
        {
            var ventaEva = new VentaService<VentaEvaModel>(new EvaResolver());
            var dataEva = ventaEva.GenerarVenta<VentaEvaModel>();
            var JsonEva = Utils.ConvertirAJson(dataEva);
            Console.WriteLine("Numero de factura: {0}", dataEva.Nro);
            Console.WriteLine(JsonEva);
        }

    }
}
