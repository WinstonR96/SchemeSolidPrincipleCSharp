using GeneradorDeVentas.Enums;
using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Models.Gk;
using GeneradorDeVentas.Models.Eva;
using GeneradorDeVentas.Resolvers;
using GeneradorDeVentas.Services;
using System;
using Serilog;

namespace GeneradorDeVentas
{
    public class Program
    {
        private static string pos;
        private static readonly ILogger log = LoggerApp.Instance.GetLogger.ForContext<Program>();

        static void Main(string[] args)
        {
            //Obtener las configuraciones del archivo de configuracion
            Configurar();
            //Generamos las ventas
            var obj = ProcesarVentas();
            //Convertimos esa venta en JSON
            var jsonObj = Utils.ConvertirAJson(obj);
            //Enviamos ese JSON a la funcion de azure
            EnviarData(jsonObj);
            Console.ReadLine();
        }

        private static void Configurar()
        {
            log.Information("Inicializando");
            log.Information("Obteniendo configuración.....");

            //Obteniendo configuración
            pos = Utils.Configuracion()["Pos"].ToLower();

            

            log.Information("Configuración Correcta");

        }

        private static object ProcesarVentas()
        {
            log.Information("Procesando ventas");
            Pos _pos = (Pos)Enum.Parse(typeof(Pos), pos);
            object result;
            switch (_pos)
            {
                case Pos.eva:
                    result = VentaEva();
                    break;
                case Pos.gk:
                    result = VentaGk();
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }

        private static object VentaGk()
        {
            //Instanciamos la clase Venta Service para que sea de tipo Gk
            var ventaGk = new VentaService<VentaGkModel>(new GkResolver());
            //Generamos venta tipo Gk
            var dataGk = ventaGk.GenerarVenta();
            return dataGk;
        }

        private static object VentaEva()
        {
            //Instanciamos la clase Venta Service para que sea de tipo Eva
            var ventaEva = new VentaService<VentaEvaModel>(new EvaResolver());
            //Generamos venta tipo eva
            var dataEva = ventaEva.GenerarVenta();
            //Convertimos la venta en Json
            return dataEva;
        }

        private static void EnviarData(string data)
        {
            //Instanciamos la clase Cloud Service
            var cloud = new CloudService(new AzureResolver());
            cloud.Post(data);
        }

    }
}
