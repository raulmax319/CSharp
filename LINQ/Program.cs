using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Entities;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\vscode\Cursos\Curso OO C#\Projetos\exercicios\LINQ\in.csv";

            List<Products> list = new List<Products>();

            using (StreamReader streamReader = File.OpenText(path)) {
                while(!streamReader.EndOfStream) {
                    string[] fields = streamReader.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Products(name, price));
                }
                var avg = list.Select(p => p.price).
                    DefaultIfEmpty(0.0).Average();

                System.Console.WriteLine($"Average price: {avg}");

                var names = list.
                    Where(p => p.price < avg).
                    OrderByDescending(p => p.name).
                    Select(p => p.name);
                    foreach (string name in names) {
                        System.Console.WriteLine(name);
                    }
            }
        }
    }
}
