using System;

namespace NomeIdadeMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            System.Console.WriteLine("Insert your name here:");
            a.nome = System.Console.ReadLine();
            System.Console.WriteLine("Insert your age here:");
            a.idade = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Insert your name here:");
            b.nome = System.Console.ReadLine();
            System.Console.WriteLine("Insert your age here:");
            b.idade = int.Parse(System.Console.ReadLine());

            if(b.idade > a.idade) System.Console.WriteLine($"{b.nome} é mais velha e tem {b.idade} ano de idade");
            else System.Console.WriteLine($"{a.nome} é mais velha e tem {a.idade} ano de idade");
        }
    }
}
