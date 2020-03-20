using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Serilog;

namespace GeneradorDeVentas.Resolvers
{
    public class AzureResolver : ICloudService
    {
        private readonly ILogger log = LoggerApp.Instance.GetLogger.ForContext<AzureResolver>();
        public string url { get; set; }
        private static readonly HttpClient httpClient = new HttpClient();

        public AzureResolver()
        {
            this.url = Utils.Configuracion()["Endpoint"];
        }

        public void Get(string parametro)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Post(string body)
        {
            string response = null;
            log.Information("Iniciando proceso de envio de data");
            try
            {
                var httpContent = new StringContent(body);
                var responseHttp = await httpClient.PostAsync(url, httpContent);
                response = responseHttp.Content.ReadAsStringAsync().Result;
                log.Information(response);
            }catch(Exception ex)
            {
                log.Error(ex.Message);
            }
            return response;
        }
    }
}
