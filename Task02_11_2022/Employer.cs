using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    class Employer
    {
        public String Name { get; set; }
        public static Employer LookupByName(String name)
        {
            Employer res = new Employer();
            return res;
        }
    }
}
