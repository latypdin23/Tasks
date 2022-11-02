using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Вывести на экран сообщение "Как тебя зовут"
            Console.WriteLine("Как тебя зовут?");
            //name-переменная типа string
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            Console.WriteLine($"Привет {name}, {name1}");
            Console.WriteLine("Привет " + name + " " + name1);
            Console.WriteLine("Привет {0} {1}", name, name1);

            //Задание 2
            int a, b;
            Console.WriteLine("Введите число a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b=");
            b = Convert.ToInt32(Console.ReadLine());
            //явное приведение int к double
            double result = (double)a / b;
            Console.WriteLine($"a/b={result}");
            Console.WriteLine(a / b);

            //задание 3
            char symbol = 'a';
            byte numOfSymbol = (byte)symbol;
            numOfSymbol = ++numOfSymbol;
            Console.WriteLine((char)numOfSymbol);

            //задание 4
            double aa, bb, cc,x1,x2;
            aa = Convert.ToDouble(Console.ReadLine());
            bb = Convert.ToDouble(Console.ReadLine());
            cc = Convert.ToDouble(Console.ReadLine());
            double D = bb * bb - 4 * aa * cc;

            if(D>0)
            {
                x1 = (-bb + Math.Sqrt(D)) / 2 * aa;
                x2= (-bb - Math.Sqrt(D)) / 2 * aa;
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            else if(D==0)
            {
                x1= -bb / 2 * aa;
                x2 = x1;
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            else
            {
                Console.WriteLine("нет корней");
            }
            Console.ReadKey();

        }
    }
}
