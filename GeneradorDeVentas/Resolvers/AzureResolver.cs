using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeneradorDeVentas.Resolvers
{
    public class AzureResolver : ICloudService
    {
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
            var httpContent = new StringContent(body);
            HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);
            Console.WriteLine("Respuesta de la funcion Azure: {0}", response);
        }
    }
}
