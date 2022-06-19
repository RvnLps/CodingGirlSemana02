using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1506
{
    public abstract class Formas
    {
        public abstract double CalcularDimensao();
    }
    class AreaQuadrado : Formas
    {
        private double ll;
        public AreaQuadrado(double l)
        {
            ll = l;
        }

        public override double CalcularDimensao()
        {
            return ll * ll;
        }
        //public override double CalcularDimensao() => ll * ll; //outra forma de retornar valor

    }
    class AreaTriangulo : Formas
    {
        private double bb, aa;
        public AreaTriangulo(double b, double a)
        {
            bb = b; aa = a;
        }
        public override double CalcularDimensao()
        {
            return bb * aa / 2;
        }
    }

    class AreaCirculo : Formas
    {
        private double rr;
        private const double pi = 3.14159265359;
        public AreaCirculo(double r)
        {
            rr = r;
        }
        public override double CalcularDimensao()
        {
            return pi * rr * rr;
        }
    }
}
