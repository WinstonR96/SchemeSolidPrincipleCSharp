using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using Serilog;

namespace GeneradorDeVentas.Helpers
{
    public class Utils
    {
        private static readonly ILogger log = LoggerApp.Instance.GetLogger.ForContext<Utils>();

        public static string ConvertirAJson(object obj)
        {
            log.Information("Mapeando a JSON");
            string json = "";
            try
            {
                json = JsonConvert.SerializeObject(obj);
                log.Information(json);
            }
            catch(Exception ex)
            {
                log.Information(ex.Message);
            }
            return json;
        }

        public static IConfigurationRoot Configuracion()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
