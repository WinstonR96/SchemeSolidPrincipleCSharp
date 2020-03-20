using GeneradorDeVentas.Helpers;
using GeneradorDeVentas.Interfaces;
using GeneradorDeVentas.Models.Eva;
using Serilog;
using System;
using System.Collections.Generic;

namespace GeneradorDeVentas.Resolvers
{
    public class EvaResolver : IVentaService
    {
        private readonly ILogger log = LoggerApp.Instance.GetLogger.ForContext<EvaResolver>();

        public T GenerarVenta<T>()
        {
            log.Information("Generando venta de EVA");
            VentaEvaModel venta = new VentaEvaModel()
            {
                id_venta = "e78ee515-676a-450a-baac-fd418aede25e",
                bruto_ngtv = "0,00",
                bruto_pstv = "1950,00",
                cod_tienda = "350",
                cod_tipo_transac = "VENTA",
                fecha_venta = "23/12/2017 8:04:19 a.m.",
                nro_fact = "2,00",
                nro_transac = "3",
                prefijo = "I090",
                id_usuario = "93402162",
                valor_cambio = "3050,00",
                Articulos = new List<Articulo>() {
                    new Articulo()
                    {
                        cantidad = "1.00",
                        cod_articulo = "0000214",
                        cod_leido = "7702011088802",
                        consecutivo = "1",
                        valor_imp = "120,00",
                        pctj_impuesto = "19,00",
                        valor_venta = "750,00"
                    },
                    new Articulo()
                    {
                        cantidad = "1.00",
                        cod_articulo = "0000666",
                        cod_leido = "7709992711163",
                        consecutivo = "2",
                        valor_imp = "192,00",
                        pctj_impuesto = "19,00",
                        valor_venta = "1200,00"
                    }
                },
                MediosDePago = new List<MedioDePago>()
                {
                    new MedioDePago()
                    {
                        anulado = "0",
                        cod_banco = "00",
                        cod_medio_pago = "1",
                        documento = "0",
                        meses_plazo = "0",
                        nro_cuenta = "00",
                        valor = "1950,00"
                    }
                }

            };
            return (T)Convert.ChangeType(venta, typeof(T));
        }
    }
}
