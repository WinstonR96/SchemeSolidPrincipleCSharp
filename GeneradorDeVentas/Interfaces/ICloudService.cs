using System.Threading.Tasks;

namespace GeneradorDeVentas.Interfaces
{
    public interface ICloudService
    {
        public string url { get; set; }

        public void Get(string parametro);

        public Task Post(string body);

    }
}
