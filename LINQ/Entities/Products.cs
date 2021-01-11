namespace Entities {
    class Products {
        public string name { get; set; }
        public double price { get; set; }

        public Products(string name, double price) {
            this.name = name;
            this.price = price;
        }
    }
}