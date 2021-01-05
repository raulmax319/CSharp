using System;

namespace conversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Cotacao do dolar: {ConversorDeMoedas.cotacao}");
            System.Console.WriteLine();

            System.Console.Write("Quantos dolares voce vai comprar: $ ");
            double quantidade = ConversorDeMoedas.dolarParaReal(double.Parse(System.Console.ReadLine()));

            System.Console.WriteLine();
            System.Console.Write($"Valor a ser pago: R$ {quantidade}");
        }
    }
}
