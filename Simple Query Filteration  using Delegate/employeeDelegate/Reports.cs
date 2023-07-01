using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeDelegate
{
    public delegate bool filteration(Employee e);
    internal class Reports
    {
        public void ProcessEmployee(Employee[] emp, string Title, filteration cond)
        {

            Console.WriteLine(Title);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" name | age | salary |  totalSales  ");
            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.name}   |  {e.age}  |  {e.salary}  |  {e.totalSales} ");
                }
            }
            Console.WriteLine("\n\n");

        }
    }
}
