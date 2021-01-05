using System;

namespace mediaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado a, b;

            a = new Empregado();
            b = new Empregado();

            System.Console.WriteLine("Insert your name here:");
            a.nome = System.Console.ReadLine();
            System.Console.WriteLine("Insert your salary here:");
            a.salario = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Insert your name here:");
            b.nome = System.Console.ReadLine();
            System.Console.WriteLine("Insert your salary here:");
            b.salario = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Salario medio = {(a.salario + b.salario) / 2}");
        }
    }
}
