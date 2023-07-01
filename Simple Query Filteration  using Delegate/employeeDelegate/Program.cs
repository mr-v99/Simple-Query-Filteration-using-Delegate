namespace employeeDelegate
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[]
            {
                new Employee(name: "Ali", age: 20,salary: 800m, totalSales: 2500m),
                new Employee(name: "Ahmed", age: 21,salary: 900m, totalSales: 32000m),
                new Employee(name: "yosif", age: 22,salary: 1000m, totalSales: 1200m),
                new Employee(name: "Ali", age: 27,salary: 1110m, totalSales: 17770m),
                new Employee(name: "Ali", age: 25,salary: 800m, totalSales: 4111m),
                new Employee(name: "Ali", age: 20,salary: 800m, totalSales: 748m),
            };

            Reports reports = new Reports();
            reports.ProcessEmployee(emps, "total sales morethan 7500", (emp) => emp.totalSales >= 7500m);
            reports.ProcessEmployee(emps, "Age morethan than 25", (emp) => emp.age >= 25);
            reports.ProcessEmployee(emps, "Salary more than 1000", (emp) => emp.salary >= 1000m);
        }

        
    }
}