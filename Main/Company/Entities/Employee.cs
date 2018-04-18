using Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities
{
    public class Employee : Base , IBoss
    {
        public Employee(string name, DateTime beginning) : base(name, beginning) 
        {
            // magic numbers :)
            MaxPercent = 30;
            ProcentForYears = 3;

            this.Name = name;
            this.BeginningWork = beginning;
        }
        
        public Base Boss { get; private set; }

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
    }
}
