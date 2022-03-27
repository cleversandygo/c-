using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_5
{
    

    class Program
    {
        public delegate Employee ManageWorker(int id);
        static void Main(string[] args)
        {
            Action dosomething;
            ManageWorker manage;

            Boss boss1 = new Boss();

            dosomething = boss1.Display;

            manage = boss1.Use;
            manage = boss1.Fire;

            dosomething();
            Console.WriteLine("Dealing with {0}", manage(1));
            dosomething();




        }
    }
}
