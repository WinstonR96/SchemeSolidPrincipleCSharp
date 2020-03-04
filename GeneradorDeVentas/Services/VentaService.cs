using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models;

namespace GeneradorDeVentas.Services
{
    public class VentaService
    {
        private readonly IVentaService _ventaService;

        public VentaService(IVentaService ventaService)
        {
            _ventaService = ventaService;
        }

        public Venta GenerarVenta()
        {
            var venta = _ventaService.GenerarVenta();
            return venta;
        }
    }
}
