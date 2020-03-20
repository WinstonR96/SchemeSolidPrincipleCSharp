using FluentAssertions;
using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Models.Eva;
using GeneradorDeVentas.Resolvers;
using GeneradorDeVentas.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TestVentaService
{
    public class AzureTest
    {
        [Fact]
        public async Task Envio_15_ventas()
        {
            //Generamos un listado de ventas
            for (int i = 1; i <= 15; i++)
            {
                var ventaEva = new VentaService<VentaEvaModel>(new EvaResolver()).GenerarVenta();
                //Serializamos el listado de ventas a Json
                string json = Utils.ConvertirAJson(ventaEva);

                //Enviamos al server
                var cloud = new CloudService(new AzureResolver());
                string contenido = cloud.Post(json);
                contenido.Should().BeOfType<string>();
            }
        }
    }
}
