using GeneradorDeVentas.Interfaces;

namespace GeneradorDeVentas.Services
{
    public class CloudService
    {
        private readonly ICloudService _cloudService;

        public CloudService(ICloudService cloudService)
        {
            _cloudService = cloudService;
        }

        public void Get(string parametro)
        {
            _cloudService.Get(parametro);
        }

        public string Post(string body)
        {
            var resultado = _cloudService.Post(body).Result;
            return resultado;
        }
    }
}
