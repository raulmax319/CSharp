using System;
using productOrder.Entities.Enums;

namespace productOrder.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order() {
        }

        public Order(DateTime time, OrderStatus status) {
            Moment = time;
            OrderStatus = status;
        }

        public void AddItem(OrderItem order) {
        }

        public void RemoveItem(OrderItem order) {
        }

        public double Total() {
            return 0;
        }
    }
}