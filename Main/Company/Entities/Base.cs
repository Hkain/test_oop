using Company.Unility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities
{
    public abstract class Base
    {
        protected internal string Name;
        protected internal DateTime BeginningWork;
        protected internal int BaseSalary = 1000;

        protected internal int MaxPercent;
        protected internal int ProcentForYears;

        public Base(string name, DateTime beginning)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Huston we have a problem!!! Name is Empty or null");

            Name = name;
            BeginningWork = beginning;
        }

        public double GetSalary()
        {
            if (BeginningWork == new DateTime()) // not itialize, base value 01.01.01
                return BaseSalary;

            var salary = BaseSalary;
            int calendar_years = DateTime.Now.Year - BeginningWork.Year;
            if (calendar_years > 0)
            {
                var surcharge = BaseSalary * (calendar_years * ProcentForYears) / 100;
                var maxSurcharge = BaseSalary * MaxPercent / 100;

                salary += surcharge > maxSurcharge ? maxSurcharge : surcharge;
            }
            return salary;
        }

        public double GetSalaryForPeriod(DateTime startPeriod, DateTime endPeriod)
        {
            var mountg = UtilityDataTime.DiferentMonth(startPeriod, endPeriod);
            return GetSalary() * (mountg == 0 ? 1 : mountg);
        }
    }
}
