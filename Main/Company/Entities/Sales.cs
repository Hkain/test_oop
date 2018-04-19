using Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities
{
    public class Sales : Base , IBoss, IEmpMethods
    {
        public Sales(string name, DateTime beginning) : base(name, beginning)
        {
            // magic numbers :)
            MaxPercent = 35;
            ProcentForYears = 1;

            this.Name = name;
            this.BeginningWork = beginning;
        }

        private Base Boss;
        private Base[] Employees;
        public void AddBoss(Base boss)
        {
            Boss = boss ?? throw new Exception("Ooppppsssss, boss == null");
        }

        public void AddEmployees(Base[] emp)
        {
            Employees = emp;
        }

        public List<Base> GetAllEmployees()
        {
            List<Base> list = new List<Base>();
            foreach (var emp in Employees)
            {
                list.Add(emp);
            }
            return list;
        }

        public void GetNameBoss()
        {
            if (string.IsNullOrEmpty(Boss.Name))
                throw new Exception("Boss not have Name ????");

            Console.WriteLine(Boss.Name);
        }
    }
}
