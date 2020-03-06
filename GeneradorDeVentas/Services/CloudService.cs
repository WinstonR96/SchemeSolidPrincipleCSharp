﻿using GeneradorDeVentas.Interfaces;

namespace GeneradorDeVentas.Services
{
    public class CloudService
    {
        private readonly ICloudService _cloudService;

        public CloudService(ICloudService cloudService)
        {
            _cloudService = cloudService;
        }

        public void Get(string parametro)
        {
            _cloudService.Get(parametro);
        }

        public void Post(string body)
        {
            _cloudService.Post(body);
        }
    }
}
