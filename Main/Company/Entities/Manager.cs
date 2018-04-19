using Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities
{
    public class Manager : Base, IBoss, IEmpMethods
    {
        public Manager(string name, DateTime beginning) : base(name, beginning)
        {
            // magic numbers :)
            MaxPercent = 40;
            ProcentForYears = 5;

            this.Name = name;
            this.BeginningWork = beginning;
        }

        private Base Boss;

        public List<Base> Employees { get; set; }

        public void AddBoss(Base boss)
        {
            Boss = boss ?? throw new Exception("Ooppppsssss, boss == null");
        }

       

 

        public void GetNameBoss()
        {
            if (string.IsNullOrEmpty(Boss.Name))
                throw new Exception("Boss not have Name ????");

            Console.WriteLine(Boss.Name);
        }

        public void AddEmployees(Base emp)
        {
            Employees.Add(emp);
        }
    }
}
