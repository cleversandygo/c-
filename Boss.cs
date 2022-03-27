using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_5
{
    class Boss
    {
        List<Employee> staff;

        public Boss()
        {
            staff = Agency.Generate();
        }

        public void Display()
        {
            foreach (Employee x in staff)
            {
                Console.WriteLine(x);
            }
        }

        public Employee Use(int id)
        {
            foreach (Employee e in staff)
            {
                if (e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public Employee Fire(int id)
        {
            Employee e = Use(id);
            if (e != null)
            {
                staff.Remove(e);
            }
            return e;
        }
    }
}
