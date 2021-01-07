namespace Taxes.Entities {
    abstract class Payer {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Payer(string name, double annualInc) {
            Name = name;
            AnnualIncome = annualInc;
        }

        public abstract double Tax();
    }
}