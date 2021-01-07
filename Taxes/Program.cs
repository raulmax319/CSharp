using System;
using System.Collections.Generic;
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

            for(int i = 0; i <= n; i++) {
                System.Console.Write("Individual or Company (i/c): ");
                char individualOrCompany = int.Parse(System.Console.ReadLine());
                
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
                    double numOfEmployees = double.Parse(System.Console.ReadLine());

                    taxPayers.Add(new Company(name, income, numOfEmployees));
                }
                else
                    System.Console.WriteLine("Nao é uma opcao valida.");
                }

                double sum;

                System.Console.WriteLine("TAXES PAID:");
                foreach(Payer payer in taxPayers) {
                    System.Console.Write($"{payer.Name}: $ {payer.Tax()}");
                    sum += payer.Tax();
                }
                System.Console.WriteLine($"TOTAL TAXES: {sum}");
        }
    }
}
