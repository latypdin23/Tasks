using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    class Phone
    {
        public string Name { get; set; }
        public virtual void Call()  //виртуальный
        {
            Console.WriteLine("Я звоню");
        }
    }
}
