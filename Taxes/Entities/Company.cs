namespace Taxes.Entities {
    class Company : Payer {
        public int Employees { get; set; }

        public Company(string name, double annualIncome, int numOfEmployees) : base(name, annualIncome) {
            Employees = numOfEmployees;
        }

        public override double Tax() {
            if(Employees <= 10) return (AnnualIncome * 0.16);
            else return (AnnualIncome * 0.14);
        }
    }
}