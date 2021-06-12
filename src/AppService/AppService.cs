using System;

namespace AppService
{
    public class AreaService : IAreaService
    {
        public double CalcularAreaCirculo(double raio) => Math.PI * Math.Pow(raio, 2);
        
    }
}
