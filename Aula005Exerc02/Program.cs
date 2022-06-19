using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula005Exerc02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva uma classe em que cada objeto representa um vôo que acontece em determinada data e em determinado 
            horário. Cada vôo possui no máximo 100 passageiros, e a classe permite controlar 
            a ocupação das vagas.
            A classe deve ter os seguintes métodos:
            Ocupar Vaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro, e retorna verdadeiro 
            se a cadeira ainda não estiver ocupada (operação foi bem sucedida) e falso caso contrário
            Vagas Livres: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo;
            Cadeira Livre: Retorna o número da próxima cadeira livre;
            Ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro. Caso a cadeira esteja ocupada 
            exibe uma mensagem, caso esteja vazia, reserva e exibe uma mensagem de confirmação;
            Ver horário: Imprime a data e o horário do vôo.

            Obs: para fins de teste a ocupação das cadeiras foi gerada para os status de "ocupado" para as cadeiras ímpares 
            e "livre" para pares;e a próxima cadeira livre é um valor fixo; 
            */


            ReservaVoo reservas = new ReservaVoo();
            reservas.NumVoo = 12345;
            reservas.DataVoo = "10/06/2022";
            reservas.HoraVoo = "22h";
            reservas.NumCadeira = 33;
            Console.WriteLine("---------- Exercicio 2 ----------\n");
            int escolha;
            reservas.VagasLivres();
            Console.WriteLine("Escolha uma cadeira!\n");
            escolha = int.Parse(Console.ReadLine());
            if (reservas.ReservaCadeira(escolha) == true)
            {
                Console.WriteLine($"Cadeira {escolha} reservada com sucesso!" +
                    $" Para o voo {reservas.NumVoo} do dia {reservas.DataVoo} às {reservas.HoraVoo}");
            }
            else
            {
                Console.WriteLine("Cadeira ocupada!");
                reservas.CadeiraLivre();
            }


            Console.ReadLine();
        }

        public class ReservaVoo
        {
            public int NumVoo;
            public string DataVoo;
            public string HoraVoo;
            public int NumCadeira;
            public void VagasLivres()
            {
                int temporario = 50;
                Console.WriteLine($"Há {temporario} vagas livres para este voô.\n");
            }
            public void CadeiraLivre()
            {
                int temporario = 33;// resultado ficticio fixo
                Console.WriteLine($"A próxima cadeira livre é a {temporario}.\n");
            }
            public bool ReservaCadeira(int cadeiraEscolhida)
            {
                bool[] reservada = new bool[100];
                int i;
                for (i = 0; i < 100; i++)//preenchimento temporario para teste
                {
                    if ((i % 2) == 0)
                    {
                        reservada[i] = true;
                    }
                    else
                    {
                        reservada[i] = false;
                    }
                }
                if (reservada[cadeiraEscolhida - 1] == true)
                {
                    //Console.WriteLine("Cadeira reservada com sucesso!");
                    return true;
                }
                else
                {
                    //Console.WriteLine("Cadeira ocupada!");
                    return false;
                }

            }
        }
    }
}
