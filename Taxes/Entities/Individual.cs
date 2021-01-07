namespace Taxes.Entities {
    class Individual : Payer {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double health) : base(name, annualIncome) {
            HealthExpenditures = health;
        }

        public override double Tax() {
            return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
    }
}