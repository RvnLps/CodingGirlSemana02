using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula005Exerc03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe Calculadora, que possui como métodos a multiplicação, divisão, subtração e soma
            //de dois valores e exibe para o usuário.
            Calculadora Calc = new Calculadora();
            Console.Write("\n\tEntre com o primeiro valor: ");
            Calc.Num1 = double.Parse(Console.ReadLine());
            Console.Write("\tEntre com o segundo valor: ");
            Calc.Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\tResultados:\n");
            Console.WriteLine($"\tMuliplicaçação dos valore: {Calc.Mult(Calc.Num1, Calc.Num2).ToString("0.00")}");
            Console.WriteLine($"\tDivisão dos valore: {Calc.Divi(Calc.Num1, Calc.Num2).ToString("0.00")}");
            Console.WriteLine($"\tSubtração dos valore: {Calc.Subt(Calc.Num1, Calc.Num2).ToString("0.00")}");
            Console.WriteLine($"\tSoma dos valore: {Calc.Soma(Calc.Num1, Calc.Num2).ToString("0.00")}");
            Console.ReadLine();
        }
    }
    public class Calculadora
    {
        public double Num1;
        public double Num2;
        public double Mult(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
        public double Divi(double Num1, double Num2)
        {
            return Num1 / Num2;
        }
        public double Subt(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
        public double Soma(double Num1, double Num2)
        {
            return Num1 + Num2;
        }

    }
}
