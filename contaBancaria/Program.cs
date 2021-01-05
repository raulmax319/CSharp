using System;

namespace contaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Entre o Titular da conta: ");
            string nome = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Havera deposito inicial (s/n)? ");
            char yn = char.Parse(System.Console.ReadLine());
            System.Console.WriteLine();

            Random rnd = new Random();
            int conta = rnd.Next(1000, 10000);

            Conta novaConta = new Conta(nome, conta);

            
            if(yn == 's' || yn == 'S') {
                System.Console.Write("Entre o valor de deposito inicial: ");
                novaConta.Deposito(double.Parse(System.Console.ReadLine()));
                System.Console.WriteLine();
            }
            else if(yn == 'n' || yn == 'N') System.Console.WriteLine();
            else System.Console.Write("Opcao invalida. Saindo da operacao...");

            System.Console.WriteLine("Dados da conta:");
            System.Console.Write(novaConta);
            System.Console.WriteLine();

            System.Console.Write("Entre um valor para deposito: ");
            novaConta.Deposito(double.Parse(System.Console.ReadLine()));
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.Write(novaConta);
            System.Console.WriteLine();

            System.Console.Write("Entre um valor para saque: ");
            novaConta.Saque(double.Parse(System.Console.ReadLine()));
            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.Write(novaConta);
        }
    }
}
