using GeneradorDeVentas.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;

namespace GeneradorDeVentas.Helpers
{
    public class Utils
    {
        public static string ConvertirAJson(Object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }

        public static void WriteToLog(string logFile, string text)
        {
            var log = File.AppendText(logFile);
            log.WriteLine(text);
            log.Dispose();
        }

        public static IConfigurationRoot Configuracion()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();
            return configuration;
        }
    }
}
