using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022.Job
{
    public class Lawyer:Work, ILaw
    {
        public override void DoWork()
        {
            Console.WriteLine("I'm lawyer");
        }

        public void DoLaw()
        {
            Console.WriteLine("I'm lawyer");
        }

        public void CheckCrime()
        {
            Console.WriteLine("I'm lawyer");
        }

        public override decimal Salary { get; set; }
    }
}
