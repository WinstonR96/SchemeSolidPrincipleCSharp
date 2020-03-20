using GeneradorDeVentas.Models.Eva;
using GeneradorDeVentas.Resolvers;
using GeneradorDeVentas.Services;
using FluentAssertions;
using Xunit;

namespace TestVentaService
{
    public class VentaEvaTest
    {
        [Fact]
        public void Tipo_De_Venta_Es_Eva()
        {
            var ventaEva = new VentaService<VentaEvaModel>(new EvaResolver()).GenerarVenta();
            ventaEva.Should().BeOfType<VentaEvaModel>();
        }
    }
}
