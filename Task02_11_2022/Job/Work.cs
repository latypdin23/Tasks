using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022.Job
{
    public abstract class Work
    {
        public string Name { get; set; }

        public abstract decimal Salary { get; set; }
        public abstract void DoWork();
    }
}
