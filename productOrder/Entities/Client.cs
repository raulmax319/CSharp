using System;
using System.Collections.Generic;

namespace productOrder.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }

        public Client() {
        }

        public Client(string name, string email, string date) {
            Name = name;
            Email = email;
            BirthDate = date;
        }
    }
}