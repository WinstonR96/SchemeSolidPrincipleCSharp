﻿using GeneradorDeVentas.Resolvers;
using GeneradorDeVentas.Services;
using System;
using System.Threading.Tasks;

namespace GeneradorDeVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var venta = new VentaService(new VentaEva());
            Console.WriteLine(venta.GenerarVenta().Nro);
            Console.ReadLine();
        }        
    }
}
