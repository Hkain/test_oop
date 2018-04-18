using Company.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCompany
{
    [TestFixture]
    public class TestEmployee
    {
        [Test]
        public void Test_employee_salary_true()
        {
            var emp = new Employee("Alex", DateTime.Now);
            var result = emp.GetSalary();
            Assert.AreEqual(result, 1000);
        }

        [Test]
        public void Test_employee_maxSalary_true()
        {
            var emp = new Employee("alex", new DateTime(1999, 10, 10));
            var result = emp.GetSalary();
            Assert.AreEqual(result, 1300);
        }
    }
}
