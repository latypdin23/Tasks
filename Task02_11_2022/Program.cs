using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    class Program
    {
        static void Task1()
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
            double aa, bb, cc, x1, x2;
            aa = Convert.ToDouble(Console.ReadLine());
            bb = Convert.ToDouble(Console.ReadLine());
            cc = Convert.ToDouble(Console.ReadLine());
            double D = bb * bb - 4 * aa * cc;

            if (D > 0)
            {
                x1 = (-bb + Math.Sqrt(D)) / 2 * aa;
                x2 = (-bb - Math.Sqrt(D)) / 2 * aa;
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            else if (D == 0)
            {
                x1 = -bb / 2 * aa;
                x2 = x1;
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
            else
            {
                Console.WriteLine("нет корней");
            }
        }
        static void Main(string[] args)
        {
            //Задача 1
            Console.WriteLine("Task1");
            int x=int.Parse(Console.ReadLine());
            double y;
            if(x>0)
            {
                 y = Math.Sin(x);
            }
            else
            {
                 y = Math.Cos(x);
            }


            //Задача 2
            Console.WriteLine("Task2");
            int a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("chetnoe");
            }
            else
            {
                Console.WriteLine("ne chetnoe");
                if (a % 10 == 7)
                {
                    Console.WriteLine("заканчивается 7");
                }
            }

            Console.WriteLine("Task3");
            Console.WriteLine("Введите рост первого человека:");
            double person1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост второго человека:");
            double person2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост третьего человека:");
            double person3 = double.Parse(Console.ReadLine());

            if(person1==person2)
            {
                if(person2==person3)
                {
                    Console.WriteLine("Равны");
                }
                else
                {
                    Console.WriteLine("1 и 2 равны, а 3 не равен");
                }
            }
            else
            {
                Console.WriteLine("1 и 2 не равны");
            }

            if((person1==person2) && (person2==person3))
            {
                Console.WriteLine("Равны");
            }
            //Задача 4
            Console.WriteLine("Task4");
            Console.WriteLine("Введите номер n");
            byte n=byte.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("понедельник");
            }
            else if(n==2)
            {
                Console.WriteLine("вторник");
            }
            else if(n==3)
            {
                Console.WriteLine("среда");
            }
            else if(n==4)
            {
                Console.WriteLine("четверг");
            }
            else if(n==5)
            {
                Console.WriteLine("пятница");
            }
            else if(n==6)
            {
                Console.WriteLine("суббота");
            }
            else if (n == 7)
            {
                Console.WriteLine("воскресенье");
            }
            else
            {
                Console.WriteLine("не то число");
            }


            switch(n)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("понедельник");
                    break;
                case 5:
                    Console.WriteLine("вторник");
                    break;
                case 6:
                    Console.WriteLine("среда");
                    break;
                case 7:
                    Console.WriteLine("вторник");
                    break;

                default:
                    Console.WriteLine("среда");
                    break;
            }

            string q = Console.ReadLine();
            switch (q)
            {
                case "Hello":
                    Console.WriteLine("said hello");
                    break;
                case "Hi":
                    Console.WriteLine("said hi");
                    break;

                default:
                    Console.WriteLine("another");
                    break;
            }
            Console.ReadKey();

        }
    }
}
