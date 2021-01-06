using System;

namespace workerContracts.Entities.Contracts {
    class HourContract {
        public static DateTime Date { get; set; }
        public static double ValuePerHour { get; set; }
        public static int Hours { get; set; }

        public static double TotalValue() {
            return Hours * ValuePerHour;
        }
    }
}