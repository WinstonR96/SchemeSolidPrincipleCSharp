using GeneradorDeVentas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorDeVentas.Resolvers
{
    public class AzureResolver : ICloudService
    {
        public string url { get; set; }

        public void Get(string parametro)
        {
            throw new NotImplementedException();
        }

        public void Post(string body)
        {
            throw new NotImplementedException();
        }
    }
}
