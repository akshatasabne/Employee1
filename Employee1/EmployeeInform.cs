using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    public class EmployeeInform
    {
        private int id, salary;
        private string name, city;

        public EmployeeInform(int id, int salary, string name, string city = "pune")
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
        }
        public string Display()
        {
            return $"Employee Info{id}\n{salary}\n{name}\n{city}";
        }
    }
}
