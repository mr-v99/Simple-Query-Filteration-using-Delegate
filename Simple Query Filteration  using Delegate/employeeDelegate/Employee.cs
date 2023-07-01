using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeDelegate
{
    public class Employee
    {

        public string name { get; set; }
        public int age { get; set; }
        public decimal salary { get; set; }

        public decimal totalSales { get; set; }
        public Employee(string name, int age, decimal salary, decimal totalSales)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.totalSales = totalSales;
            
        }


    }
}
