using System;
using workerContracts.Entities;
using workerContracts.Entities.Enums;
using workerContracts.Entities.Departments;
using workerContracts.Entities.Contracts;

namespace workerContracts {
    class Program {
        static void Main(string[] args) {


            System.Console.Write("Enter department's name: ");
            string departmentName = System.Console.ReadLine();

            Department dept = new Department(departmentName);

            System.Console.WriteLine("Enter worker data:");
            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();

            System.Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = System.Console.ReadLine();

            System.Console.Write("Base salary: ");
            double salary = double.Parse(System.Console.ReadLine());

            Worker employee = new Worker {
                Department = dept,
                Name = name,
                Level = Enum.Parse<WorkerLevel>(level),
                BaseSalary = salary,
            };

            System.Console.Write("How many contracts to this worker: ");
            int contractNumber = int.Parse(System.Console.ReadLine());

            for (int i = 1; i <= contractNumber; i++) {
                System.Console.WriteLine($"Enter #{i} contract data:");
                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(System.Console.ReadLine());

                System.Console.Write("Value per hour: ");
                double valueperH = double.Parse(System.Console.ReadLine());

                System.Console.Write("Duration: ");
                int duration = int.Parse(System.Console.ReadLine());

                HourContract contract = new HourContract {
                    Date = data,
                    ValuePerHour = valueperH,
                    Hours = duration
                };

                employee.AddContract(contract);
            }

            System.Console.Write("Enter the month and year to calculate the income (MM/YYYY): ");
            string period = System.Console.ReadLine();
            int month = int.Parse(period.Substring(0, 2));
            int year = int.Parse(period.Substring(3));

            System.Console.WriteLine($"Name: {employee.Name}");
            System.Console.WriteLine($"Department: {employee.Department.Name}");
            System.Console.WriteLine($"Income for {period}: {employee.Income(year, month)}");
        }
    }
}
