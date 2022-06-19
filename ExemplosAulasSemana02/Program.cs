using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosAulasSemana02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula 06 - Orientação a objeto

            /*
            ContaCorrente ContaGiulia = new ContaCorrente(1, 23);//primeiro objeto instanciado pela classe
            ContaGiulia.titular = "Giulia Lopes";
            ContaGiulia.saldo = 1000;
            Console.WriteLine($"Agência Giulia: {ContaGiulia.agencia}");
            Console.WriteLine($"Número Giulia: {ContaGiulia.numero}");
            //Console.WriteLine($"\nSaldo da Giulia: {ContaGiulia.saldo}.");
            ContaGiulia.ConsultarSaldo();
            bool resultadoSaque = ContaGiulia.Sacar(350);
            Console.WriteLine($"Saque: {resultadoSaque}");
            //Console.WriteLine($"Saldo atual: {ContaGiulia.saldo}");
            ContaGiulia.ConsultarSaldo();
            ContaGiulia.Depositar(500);
            ContaGiulia.ConsultarSaldo();

            ContaCorrente ContaGabriela = new ContaCorrente(2, 46);//segundo objeto instanciado pela classe
            ContaGabriela.titular = "Gabriela Silva";
            ContaGabriela.saldo = 10;
            ContaGabriela.agencia = 00000;
            ContaGabriela.numero = 12345;
            Console.WriteLine($"Agência Gabriela: {ContaGabriela.agencia}");
            Console.WriteLine($"Número Gabriela: {ContaGabriela.numero}");
            ContaGabriela.ConsultarSaldo();

            ContaGiulia.Transferir(200, ContaGabriela);
            ContaGiulia.ConsultarSaldo();
            ContaGabriela.ConsultarSaldo();
            Console.WriteLine("\n");

            ContaCorrente ContaGabriel = new ContaCorrente(100, 3, 18);
            Console.WriteLine($"Agência Gabriel: {ContaGabriel.agencia}");
            Console.WriteLine($"Número Gabriel: {ContaGabriel.numero}");
            ContaGabriel.ConsultarSaldo();

            ContaCorrente ContaBruno = new ContaCorrente();
            Console.WriteLine($"Agência Bruno: {ContaBruno.agencia}");
            Console.WriteLine($"Número Bruno: {ContaBruno.numero}");
            ContaBruno.ConsultarSaldo();
            Console.ReadLine();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Aula 7 - Encapsulamento

            //Testando modificadore:
            /*
            Carro carros = new Carro();
            Console.WriteLine(carros.modelo);
            carros.ImprimirModelo();
            */

            //Testando acessores
            /*
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Giulia";
            Console.WriteLine(pessoa.Nome);
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Aula 8 - Herança: exemplo do animal

            /*
            Gato gato = new Gato();
            gato.SomDoAnimal();
            Console.WriteLine(gato.NomeCiencífico);
            */

            var meuQuarto = new Quarto();
            var minhaCozinha = new Cozinha();
            var meuBanheiro = new Banheiro();
            Casa minhaCasa =  new Casa(meuQuarto, minhaCozinha, meuBanheiro);
            minhaCasa.Proprietario = "Giulia";
            Console.WriteLine(minhaCasa.Proprietario);
            Console.WriteLine(minhaCasa.ToString());

            Console.ReadLine();
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Aula 6

    public class ContaCorrente
    {       
        //Atributos
        public string titular;
        public int agencia;
        public int numero;
        public double saldo;

        //Métodos especiais
        // Constutores levam o mesmo nome da classe
        // Pode-se ter mais de um tipo de contrutor, com assinaturas diferentes
        public ContaCorrente(int agencia, int numero) // método construtor que inicializa as variáveis da classe
        {
            this.agencia = agencia;
            this.numero = numero;
        }
        public ContaCorrente(double saldoInicial, int agencia, int numero)// construtor com parâmetros
        {
            this.saldo = saldoInicial;
            this.agencia = agencia;
            this.numero = numero;
        }
        public ContaCorrente()// construtor sem parámetro, com valor de inicialização fixo
        {
            this.saldo = 1000;
        }

        //Métodos
        public bool Sacar(double valor) //  quando se declara o tipo do método, este rettorna resposta
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor) // void não devolve valores, apenas executa uma ação
        {
            this.saldo += valor;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo de " + this.titular + " é " + this.saldo);
        }
       public bool Transferir(double valor, ContaCorrente contaDestino) // aqui usamos como um dos parâmetros um objeto derivado da mesma classe
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Aula 7

    //testando modificadores
    class Carro 
    {
        /*
        //public string modelo = "Fiat"; // modificador public permite acesso a todas as classe
        //private string modelo = "Fiat"; // modificador private permite acesso apenas dentro da classe
        public void ImprimirModelo() // exemplo de como usar uma variável de dentro da classe, não funcionou!
        {
            Console.WriteLine(Carro.modelo);
        }
        */
    }

    // Testando visibilidade:
    class A
    {
        protected int x = 123;
    }
    class B:A // B é subclasse de A
    {
        /*static void Main()
        {
            var a = new A();
            var b = new B();
            //a.x = 10; // erro, pois a é da classe privada A
            b.x = 10; // permitido, pois b é uma classe derivada de A
            Console.WriteLine(b.x);
        }*/

    }

    // Acesssadores  e duas formas de usá-los
    class Pessoa
    {   
        //primeira forma:
        /*private string nome;
        public string Nome // a ordem ser set e get influencia?
        {
            get // pega a informação de dentro da classe e externaliza
            {
                return nome;
            }
            set //´pega informação externa e coloca na classe
            {
                nome = value;
            }
        }*/

        //Segunda forma:
        public string Nome
        {
            get;
            set;
        }
    }
  

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Aula  8

    class Animal // Classse mãe/superclasse
    {
        public string NomeCiencífico { get; set; }
    }

    /*
    sealed class Animal // Classse mãe/superclasselacrada
    {
        public string NomeCiencífico { get; set; }
    }
    */

    class Mamifero : Animal // Classe filha/subclasse da classe Animal
    {
         public void SomDoAnimal()
        {
            Console.WriteLine("Mamífero tem som");
        }
    }
    class Gato : Mamifero // Subclasse da classe Mamifero, descendente da superclase Animal
    {
        public Gato()
        {
            this.NomeCiencífico = "Felis Catus";
        }
    }

    // Composição: em vez de codificar um métoda na classe base, delegamos o trabalho para um classe específica
    public class Banheiro
    {
        public string Descricao()
        {
            return "Banheiro";
        }
    }
    public class Cozinha
    {
        public string Descricao()
        {
            return "Cozinha";
        }
    }
    public class Quarto
    {
        public string Descricao()
        {
            return "Quarto";
        }
    }

    public class Casa
    {
        public Banheiro banheiro;
        public Cozinha cozinha;
        public Quarto quarto;
        public string Proprietario { get; set; }
        public Casa (Quarto _quarto, Cozinha _cozinha, Banheiro _banheiro) // Construtor
        {
            quarto = _quarto;
            cozinha = _cozinha;
            banheiro = _banheiro;
        }
        public override string ToString()
        {
            return $"{quarto.Descricao()} - {cozinha.Descricao()} + {banheiro.Descricao()}";
        }
    }

}