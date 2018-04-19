using Company.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var employee = new Employee("alex", new DateTime(1999,10,10));
            var manadger = new Manager("viktor", new DateTime(2000,01,01));
           
            Console.WriteLine(employee.GetSalary());
            Console.WriteLine(employee.GetSalaryForPeriod(new DateTime(2017,01,10), new DateTime(2017,10,10)));


        }
    }
}
