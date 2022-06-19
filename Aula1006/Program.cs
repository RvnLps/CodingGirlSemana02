using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atividade 1
            /*
            string nomeDoUsuario;
            int idadeDoUsuario;
            const int anoAtual = 2022;

            Console.Write("Digite seu nome: ");
            nomeDoUsuario = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idadeDoUsuario = int.Parse(Console.ReadLine());

            //Console.Write("Digite o ano atual: ");
            //anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nOlá {nomeDoUsuario}, você nasceu em {anoAtual - idadeDoUsuario}.");
            Console.ReadLine();
            */

            // Atividade 2

            double quilometrosPercorridosPeloVeiculo;
            Console.Write("Quantos Km você percorreu?");
            quilometrosPercorridosPeloVeiculo = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nSeu veículo percorreu um total de {quilometrosPercorridosPeloVeiculo * 0,621} milhas.");
            Console.ReadLine();
        }
    }
}
