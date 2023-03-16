using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    class ButtonPhone:Phone
    {
        public Camera Camera { get; set; }
        public void PlaySnake()
        {
            Console.WriteLine("Я играю в змейку на ");
        }
        public override void Call()
        {
            Console.WriteLine("Я по-другому зваоню");
        }
    }
}
