using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_5
{
    abstract class Agency
    {
        public static List<Employee> Generate()
        {
            List<Employee> employees = new List<Employee>();
            Employee e1 = new Employee { Name = "Jane", Id = 1, gender = Gender.F };
            Employee e2 = new Employee { Name = "Kate", Id = 2, gender = Gender.F };
            Employee e3 = new Employee { Name = "David", Id = 3, gender = Gender.M };
            Employee e4 = new Employee { Name = "Michael", Id = 4, gender = Gender.M };
            Employee e5 = new Employee { Name = "Jackie", Id = 5, gender = Gender.X };
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);
            return employees;
        }
    }
}
