using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;

namespace GeneradorDeVentas.Services
{
    public class VentaService<T>
    {
        private readonly IVentaService _ventaService;

        public VentaService(IVentaService ventaService)
        {
            _ventaService = ventaService;
        }

        public T GenerarVenta<T>()
        {
            var venta = _ventaService.GenerarVenta<T>();
            return venta;
        }
    }
}
