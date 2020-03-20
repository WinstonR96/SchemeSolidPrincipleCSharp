using System.Net.Http;
using System.Threading.Tasks;

namespace GeneradorDeVentas.Interfaces
{
    public interface ICloudService
    {
        public string url { get; set; }

        public void Get(string parametro);

        public Task<string> Post(string body);
    }
}
