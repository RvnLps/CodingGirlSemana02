using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula005Exerc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
            //Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho.
            //Escreva os seguintes métodos para esta classe:
            //Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            //Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.

            AlunosMatriculados alunos = new AlunosMatriculados();
            alunos.NumMatricula = 12345;
            alunos.NomeAluno = "Ana";
            alunos.NotaProva1 = 8;
            alunos.NotaProva2 = 8;
            alunos.NotaTrabalho = 8;
            Console.WriteLine("----------Exercício 1 ----------\n");
            alunos.MediaParcial();
            alunos.MediaEstimada();
            Console.ReadLine();


        }
        public class AlunosMatriculados
        {
            public int NumMatricula;
            public string NomeAluno;
            public double NotaProva1;
            public double NotaProva2;
            public double NotaTrabalho;
            public void MediaParcial()
            {
                double mediaParcial;
                mediaParcial = (NotaProva1 + NotaProva2 + NotaTrabalho) / 3;//considerando peso igual entre as notas;
                Console.WriteLine($"A média atual do aluno {NomeAluno} é {mediaParcial.ToString("0.00")}.\n");
            }
            public void MediaEstimada()
            {
                double mediaEstimada;
                mediaEstimada = 28 - NotaProva1 - NotaProva2 - NotaTrabalho;//considerando média de aprovação = 7;
                Console.WriteLine($"O aluno {NomeAluno} precisa de nota {mediaEstimada.ToString("0.00")} na prova final para ser aprovado.\n");
            }
        }
    }
}
