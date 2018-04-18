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
           
            var a = new Employee("alex", new DateTime(1999,10,10));
            
            Console.WriteLine(a.GetSalary());
        }
    }
}
