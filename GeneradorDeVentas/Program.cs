using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Models;
using GeneradorDeVentas.Resolvers;
using GeneradorDeVentas.Services;
using System;
using System.Threading.Tasks;

namespace GeneradorDeVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generando venta de EVA");
            Console.WriteLine("----------------------");
            var ventaEva = new VentaService<VentaEvaModel>(new EvaResolver());
            var dataEva = ventaEva.GenerarVenta<VentaEvaModel>();
            var JsonEva = Utils.ConvertirAJson(dataEva);
            Console.WriteLine("Numero de factura: {0}",dataEva.Nro);
            Console.WriteLine(JsonEva);

            Console.WriteLine("\n----------------------\n");
            Console.WriteLine("Generando venta de GK");
            var ventaGk = new VentaService<VentaGkModel>(new GkResolver());
            var dataGk = ventaGk.GenerarVenta<VentaGkModel>();
            Console.WriteLine("Cliente: {0}", dataGk.cliente);
            Console.ReadLine();
        }        
    }
}
