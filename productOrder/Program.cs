using System;
using productOrder.Entities;
using productOrder.Entities.Enums;

namespace productOrder {
    class Program {
        static void Main(string[] args) {

            System.Console.WriteLine("Enter clients data:");
            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();

            System.Console.Write("Email: ");
            string mail = System.Console.ReadLine();

            System.Console.Write("Birth date (DD/MM/YYYY): ");
            string bDate = System.Console.ReadLine();

            Client client = new Client {
                Name = name,
                Email = mail,
                BirthDate = bDate
            };

            System.Console.WriteLine("Enter the order data:");
            System.Console.Write("Status: ");
            string stat = System.Console.ReadLine();

            System.Console.Write("How many items to this order: ");
            int n = int.Parse(System.Console.ReadLine());

            Order order = new Order(Enum.Parse<OrderStatus>(stat));

            for(int i = 1; i <= n; i++) {
                
                System.Console.WriteLine($"Enter the data for the item number #{i}:");
                System.Console.Write("Product name: ");
                string item = System.Console.ReadLine();
                
                System.Console.Write("Product price: ");
                double price = double.Parse(System.Console.ReadLine());
                
                System.Console.Write("Quantity: ");
                int qnt = int.Parse(System.Console.ReadLine());

                Product product = new Product {
                    Name = item,
                    Price = price
                };

                OrderItem orders = new OrderItem {
                    Quantity = qnt,
                    Price = price
                };
                orders.addProduct(product);
                order.AddItem(orders);
            }

            System.Console.WriteLine("ORDER SUMMARY:");
            System.Console.WriteLine($"Order moment: {order.Moment}");
            System.Console.WriteLine($"Order status: {order.OrderStatus}");
            System.Console.WriteLine($"Client: {client.Name} ({client.BirthDate}) - {client.Email}");
            System.Console.WriteLine("Order items:");
            foreach (var item in order.OrderItems) {
                foreach(var i in item.Product) {
                    System.Console.WriteLine($"{i.Name}, $ {item.Price}, Quantity: {item.Quantity}, Subtotal: $ {item.Price}");
                }
            }
            System.Console.WriteLine($"Total price: $ {order.Total()}");
        }
    }
}
