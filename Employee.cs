using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_5
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Gender gender { get; set; }

        public override string ToString()
        {
            return Name + "---" + Id + "---" + gender;
        }

    }
    enum Gender { M, F, X}
}
