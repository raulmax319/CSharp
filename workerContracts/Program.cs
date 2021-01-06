using System;
using workerContracts.Entities;
using workerContracts.Entities.Enums;
using workerContracts.Entities.Departments;

namespace workerContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            

            System.Console.Write("Enter department's name: ");
            string dep = System.Console.ReadLine();

            Department department = new Department {
                Name = dep
            };
            
            System.Console.WriteLine("Enter worker data:");
            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();

            System.Console.WriteLine();
            System.Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = System.Console.ReadLine();

            System.Console.WriteLine();
            System.Console.Write("Base salary: ");
            double salary = double.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine();
            System.Console.Write("How many contracts to this worker: ");
            int contractNumber = int.Parse(System.Console.ReadLine());

            Worker employee = new Worker {
                Dep = dep,
                Name = name,
                Level = Enum.Parse<WorkerLevel>(level),
                BaseSalary = salary
            };
            System.Console.WriteLine(employee);
        }
    }
}
