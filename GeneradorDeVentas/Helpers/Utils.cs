using GeneradorDeVentas.Interfaces;
using Newtonsoft.Json;
using System;

namespace GeneradorDeVentas.Helpers
{
    public class Utils
    {
        public static string ConvertirAJson(Object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }
    }
}
