using workerContracts.Entities.Enums;
using workerContracts.Entities.Contracts;

namespace workerContracts.Entities {
    class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public string Dep { get; set; }
        public static HourContract Contract { get; set; }

        public Worker(){
        }

        public static void AddContract() {
        }

        public static void RemoveContract() {
        }

        public static double Income(int year, int month) {
            return 0;
        }

        public override string ToString()
        {
            return $"{Name}, {Dep} {Level}, {BaseSalary}";
        }
    }
}