using System;
using System.Collections.Generic;
using productOrder.Entities.Enums;


namespace productOrder.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order() {
            Moment = DateTime.Now;
        }

        public Order(OrderStatus status) {
            Moment = DateTime.Now;
            OrderStatus = status;
        }

        public void AddItem(OrderItem order) {
            OrderItems.Add(order);
        }

        public void RemoveItem(OrderItem order) {
            OrderItems.Remove(order);
        }

        public double Total() {
            double sum = 0;
            foreach(var item in OrderItems) {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}