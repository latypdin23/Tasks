using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022.Job
{
    public class Developer: Work, ICode
    {
        public override void DoWork()
        {
            Console.WriteLine("I'm developer");
        }

        public void DoCode()
        {
            Console.WriteLine("Java");
        }

        public void DoEat()
        {
            Console.WriteLine("burger");
        }

        public override decimal Salary { get; set; }
    }
}
