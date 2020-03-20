using System.Collections.Generic;

namespace GeneradorDeVentas.Models.Eva
{
    public class VentaEvaModel
    {
        public string id_venta { get; set; }
        public string bruto_ngtv { get; set; }
        public string bruto_pstv { get; set; }
        public string cod_tienda { get; set; }
        public string cod_tipo_transac { get; set; }
        public string fecha_venta { get; set; }
        public string nro_fact { get; set; }
        public string nro_transac { get; set; }
        public string prefijo { get; set; }
        public string id_usuario { get; set; }
        public string valor_cambio { get; set; }
        public List<Articulo> Articulos { get; set; }
        public List<MedioDePago> MediosDePago { get; set; }

    }
}
