using System;

namespace productOrder.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        Client() {
        }

        Client(string name, string email, DateTime date) {
            Name = name;
            Email = email;
            Date = date;
        }
    }
}