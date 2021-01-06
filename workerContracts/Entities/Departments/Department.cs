namespace workerContracts.Entities.Departments {
    class Department {
        public string Name { get; set; }

        public Department() {
        }

        public Department(string name) {
            Name = name;
        }
    }
}