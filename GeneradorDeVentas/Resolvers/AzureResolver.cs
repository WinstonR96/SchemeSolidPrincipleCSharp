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
        static HttpClient httpClient = new HttpClient();

        public AzureResolver()
        {
            this.url = Utils.Configuracion()["Endpoint"]; ;
        }

        public void Get(string parametro)
        {
            throw new NotImplementedException();
        }

        public async Task Post(string body)
        {
            log.Information("Iniciando proceso de envio de data");
            try
            {
                var httpContent = new StringContent(body);
                HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);
                log.Information(response.ReasonPhrase);
            }catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }
    }
}
