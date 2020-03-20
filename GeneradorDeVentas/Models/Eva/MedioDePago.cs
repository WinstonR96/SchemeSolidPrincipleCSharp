using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorDeVentas.Models.Eva
{
    public class MedioDePago
    {
        public string anulado { get; set; }
        public string cod_banco { get; set; }
        public string cod_medio_pago { get; set; }
        public string documento { get; set; }
        public string meses_plazo { get; set; }
        public string nro_cuenta { get; set; }
        public string valor { get; set; }
    }
}
