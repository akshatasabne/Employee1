using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeInform inform=new EmployeeInform(101,45000,"Rohan");
            Console.WriteLine(inform.Display());
            EmployeeInform inform2 = new EmployeeInform(101, 4500, "Rohan", "Latur");
            Console.WriteLine(inform2.Display());
            EmployeeInform inform1= new EmployeeInform(id : 102, salary : 500000, name:"Rakesh",city:"Mumbai") ;
            Console.WriteLine(inform1.Display());
        }
    }
}
