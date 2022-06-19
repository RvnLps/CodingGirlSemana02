using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula006Exerc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Jogo da Velha
            Crie uma classe para o Jogo da Velha:
            A classe deve conter como dados privados uma matriz 3x3 para representar a grade do jogo
            O construtor deve inicializar a matriz vazia
            Forneça um método para exibir a matriz com status do jogo
            Permita dois jogadores humanos
            Forneça um método para jogar o jogo; todo movimento deve ocorrer em uma casa vazia; 
            depois de cada movimento valide se uma vitória ou um empate.

            OBS, usei como base a resolução do exercício da Aula 4
            */

            MostraMatriz jogoVelha = new MostraMatriz(); // instancia o objeto jogo com a classe de matriz
            string posicaoX, posicaoO;
            int i = 1;
            do
            {
                Console.WriteLine("\n Jogo da velha \n");
                if (i % 2 != 0)
                {
                    jogoVelha.mostraMatriz();
                    Console.WriteLine("\n Jogador X escolha uma posição: ");
                    posicaoX = Console.ReadLine();
                    jogoVelha.preencherMatriz(posicaoX, "X");
                    Console.WriteLine(jogoVelha.verificarJogo());
                    if (jogoVelha.verificarJogo() == "\nTemos um ganhador!\n")
                    {
                        i = 9;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    jogoVelha.mostraMatriz();
                    Console.WriteLine("\n Jogador 0 escolha uma posição: ");
                    posicaoO = Console.ReadLine();
                    jogoVelha.preencherMatriz(posicaoO, "O");
                    Console.WriteLine(jogoVelha.verificarJogo());
                    if (jogoVelha.verificarJogo() == "\nTemos um ganhador!\n")
                    {
                        i = 9;
                    }
                    else
                    {
                        i++;
                    }
                }
                //Console.WriteLine($"\ncontagem i = {i}\n");
                //Console.ReadLine();
                jogoVelha.verificarJogo();
                Console.Clear();
            } while (i <= 8);
            Console.WriteLine("\n Jogo da velha \n");
            jogoVelha.mostraMatriz();
            string final = (i <= 8) ? "\n\tEmpate\n\tDeu velha!\n" : "\nTemos um ganhador!\n\tParabêns!\n";
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
    class MostraMatriz
    {
        private string[,] matrizJV = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        private int l, c;
        public void mostraMatriz() // construtor de inicialização
        {
            for (l = 0; l < 3; l++)//mostra a matriz
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write($"\t{matrizJV[l, c]}");
                }
                Console.WriteLine("\n");
            }
        }
        public bool preencherMatriz(string posicao, string jogador)
        {
            bool controle = false;
            for (l = 0; l < 3; l++)//encontra respectiva posição na matriz para preenchimento
            {
                for (c = 0; c < 3; c++)
                {
                    if (posicao == matrizJV[l, c])
                    {
                        matrizJV[l, c] = jogador;
                        controle = true;
                        //Console.WriteLine("Continue!");                        
                    }
                }
            }
            if (controle == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string verificarJogo() // método para verificar se há ganhador
        {
            bool teste;
            if ((matrizJV[0, 0] == matrizJV[0, 1] && matrizJV[0, 1] == matrizJV[0, 2]) || //verificação de linha
                (matrizJV[1, 0] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[1, 2]) || //verificação de linha
                (matrizJV[2, 0] == matrizJV[2, 1] && matrizJV[2, 1] == matrizJV[2, 2]) || //verificação de linha
                (matrizJV[0, 0] == matrizJV[1, 0] && matrizJV[1, 0] == matrizJV[2, 0]) || //verificação de coluna
                (matrizJV[0, 1] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 1]) || //verificação de coluna
                (matrizJV[0, 2] == matrizJV[1, 2] && matrizJV[1, 2] == matrizJV[2, 2]) || //verificação de coluna
                (matrizJV[0, 0] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 2]) || //verificação de diagonal
                (matrizJV[0, 2] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 0]))   //verificação de diagonal
            {
                teste = true;
            }
            else
            {
                teste = false;
            }
            if (teste == true)
            {
                return "\nTemos um ganhador!\n";
            }
            else
            {
                return "\nContinue!\n";
            }
        }

    }
}
