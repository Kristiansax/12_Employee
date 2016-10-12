namespace _12_Employee
{
    internal class Employee
    {
        private string name;
        private string type;
        private long id;

        public Employee(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}