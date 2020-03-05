using GeneradorDeVentas.Models;

namespace GeneradorDeVentas.Interfaces
{
    public interface IVentaService
    {
        public T GenerarVenta<T>();
    }
}
