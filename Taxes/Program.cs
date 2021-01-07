using System;
using System.Collections.Generic;
using System.Globalization;
using Taxes.Entities;

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> taxPayers = new List<Payer>();

            System.Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(System.Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                System.Console.Write("Individual or Company (i/c): ");
                char individualOrCompany = char.Parse(System.Console.ReadLine());
                
                System.Console.WriteLine($"Tax payer {i} data:");

                if(individualOrCompany == 'i' || individualOrCompany == 'I') {
                    System.Console.Write("Name: ");
                    string name = System.Console.ReadLine();

                    System.Console.Write("Annual Income: ");
                    double income = double.Parse(System.Console.ReadLine());

                    System.Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(System.Console.ReadLine());

                    taxPayers.Add(new Individual(name, income, healthExp));
                }
                else if(individualOrCompany == 'c' || individualOrCompany == 'C') {
                    System.Console.Write("Name: ");
                    string name = System.Console.ReadLine();

                    System.Console.Write("Annual Income: ");
                    double income = double.Parse(System.Console.ReadLine());

                    System.Console.Write("Number of employees: ");
                    int numOfEmployees = int.Parse(System.Console.ReadLine());

                    taxPayers.Add(new Company(name, income, numOfEmployees));
                }
                else
                    System.Console.WriteLine("Nao é uma opcao valida.");
                }

                double sum = 0;

                System.Console.WriteLine();
                System.Console.WriteLine("TAXES PAID:");
                foreach(Payer payer in taxPayers) {
                    System.Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2")}");
                    sum += payer.Tax();
                }
                System.Console.WriteLine();
                System.Console.WriteLine($"TOTAL TAXES: {sum}");
        }
    }
}
