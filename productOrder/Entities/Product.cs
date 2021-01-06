namespace productOrder.Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        Product(){
        }

        Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}