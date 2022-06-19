using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var areaQuadrado = new AreaQuadrado(4);
            Console.WriteLine($"Area do quadrado = {areaQuadrado.CalcularDimensao()}");


            var areaTriangulo = new AreaTriangulo(4, 3);
            Console.WriteLine($"Area do triângulo = {areaTriangulo.CalcularDimensao()}");

            var areaCirculo = new AreaCirculo(4);
            Console.WriteLine($"Area do círculo = {areaCirculo.CalcularDimensao()}");

            Console.ReadLine();
        }
    }
}
