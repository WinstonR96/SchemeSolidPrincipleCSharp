using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorDeVentas.Interfaces
{
    public interface ICloudService
    {
        public string url { get; set; }

        public void Get(string parametro);

        public void Post(string body);

    }
}
