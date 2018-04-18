using Company.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Interfaces
{
    interface IEmpMethods
    {
        Base[] Employees { get; set; }
        void AddEmployees(Base[] emp);
        List<Base> GetAllEmployees();
    }
}
