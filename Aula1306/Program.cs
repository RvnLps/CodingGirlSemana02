using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1306
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            double alturaUsuario;
            double pesoUsuario;
            string diagnosticoUsuario;
            Console.Write("\tQual sua altura? ");
            alturaUsuario = double.Parse(Console.ReadLine());
            Console.Write("\tQual do peso? ");
            pesoUsuario = double.Parse(Console.ReadLine());
            diagnosticoUsuario = retornarDiagnosticoDoUsuario(alturaUsuario, pesoUsuario);
            Console.WriteLine($"\tSeu diagnóstico é {diagnosticoUsuario}");
            Console.ReadLine();
            //Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(alturaUsuario, pesoUsuario)}");

            string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
            {
                double IMCUsuario;
                string mensagemDiagnostico;
                IMCUsuario = pesoDoUsuario/(2*alturaDoUsuario);
                if (IMCUsuario < 18.5)
                {
                    mensagemDiagnostico = "Anêmico";
                }
                else if ((IMCUsuario >= 18.5) && (IMCUsuario <= 24.9))
                {
                    mensagemDiagnostico = "Normal";
                }
                else if ((IMCUsuario >= 25) && (IMCUsuario < 29.9))
                {
                    mensagemDiagnostico = "Sobrepeso";
                }
                else if ((IMCUsuario >= 30) && (IMCUsuario < 39.9))
                {
                    mensagemDiagnostico = "Obesidade";
                }
                else
                {
                    mensagemDiagnostico = "Obesidade grave";
                }

                return mensagemDiagnostico;
            }
            
        }
    }
}
