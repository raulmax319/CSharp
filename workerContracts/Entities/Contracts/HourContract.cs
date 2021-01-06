using System;

namespace workerContracts.Entities.Contracts {
    class HourContract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public static double TotalValue() {
            return 1;
        }
    }
}