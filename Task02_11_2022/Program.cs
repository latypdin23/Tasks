﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02_11_2022.Job;
using Task02_11_2022.Stati;

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
        static void Task2()
        {
            //Задача 1
            Console.WriteLine("Task1");
            int x = int.Parse(Console.ReadLine());
            double y;
            if (x > 0)
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
            if (a % 2 == 0)
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

            if (person1 == person2)
            {
                if (person2 == person3)
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

            if ((person1 == person2) && (person2 == person3))
            {
                Console.WriteLine("Равны");
            }
            //Задача 4
            Console.WriteLine("Task4");
            Console.WriteLine("Введите номер n");
            byte n = byte.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("понедельник");
            }
            else if (n == 2)
            {
                Console.WriteLine("вторник");
            }
            else if (n == 3)
            {
                Console.WriteLine("среда");
            }
            else if (n == 4)
            {
                Console.WriteLine("четверг");
            }
            else if (n == 5)
            {
                Console.WriteLine("пятница");
            }
            else if (n == 6)
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


            switch (n)
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

        }
        static void Task3()
        {
            /*int n = 5;
            double sum = 0.0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите зарплату: ");
                double salary = double.Parse(Console.ReadLine());
                //sum = sum+ salary;
                sum += salary;
                if(sum>=10)
                {
                    break;
                }
            }
            
            int j = 0;           
            while(j<2)
            {
                Console.WriteLine("Введите зарплату: ");
                double salary = double.Parse(Console.ReadLine());
                //sum = sum+ salary;
                sum += salary;

                j++;
            }

            int a = int.Parse(Console.ReadLine());
            double b= int.Parse(Console.ReadLine());
            while (a!=b)
            {
                Console.WriteLine("enter b");
                b= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("выполнено");


            int c= int.Parse(Console.ReadLine());
            double d;
            do
            {
                d = int.Parse(Console.ReadLine());
            } while (c != d);*/

            /*int n = int.Parse(Console.ReadLine());
            String mast = String.Empty;
            if(n==1)
            {
                mast = "Черви";
            } 
            else if(n==2)
            {
                Console.WriteLine("Бубны");
            }
            else if(n==3)
            {
                Console.WriteLine("Пики");
            }
            else if(n==4)
            {
                Console.WriteLine("Трефы");
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение");
            }
            int k= int.Parse(Console.ReadLine());
            String znach = String.Empty;
            switch(k)
            {
                case 6: znach = "шестерка"; break;
                case 7: znach = "семерка"; break;
                case 8: znach = "восьмерка"; break;
                case 9: znach = "девятка"; break;
                case 10: znach = "десятка"; break;
                case 11: znach = "валет"; break;
                case 12: znach = "дама"; break;
                case 13: znach = "король"; break;
                case 14: znach = "туз"; break;
                default: znach = "неверное значение"; break;

            }
            Console.WriteLine(znach + " " + mast);*/
            /*
            //Задача 1
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            decimal percent = 0.07M;
            byte countOfMonth = Convert.ToByte(Console.ReadLine());
            for(int i=0;i<countOfMonth;i++)
            {
                sum = sum + sum * percent;
            }
            //Задача 2
            int j = 0;
            while(j<countOfMonth)
            {
                sum = sum + sum * percent;

                j++;
            }
            */
            //Задача 3
            for (int i = 1; i < 10; i++)
            {
                for (int k = 1; k < 10; k++)
                {
                    Console.Write(i * k + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Task4()
        {
            /*Person p = new Person();
            p.name = "Dina";
            p.PrintOnConsole();

            Person p2;
            p.name = "Shalva";
            p.PrintOnConsole();

            Person p3 = new Person("Mary",12);
            p3.PrintOnConsole();

            Point point1 = new Point(5,2);
           
            point1.Print();

            WeekDay day = WeekDay.Friday;
            int a = (int)day;

            AskNameAndSayHello();
            AskNameAndSayHello();

            //int q = ;
            Console.WriteLine(Sum(5, 2));
            int w = Sum(10, 2);*/
        }
        static void Task5()
        {
            /*Console.WriteLine("Введите N=");
            int N = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[N];

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr1[i] = random.Next(-10, 10); //вернет случайное число в заданном диапазоне
            }
            foreach (int element in arr1)
            {
                Console.Write(element + ", ");
            }

            Console.WriteLine("Введите M=");
            int M= int.Parse(Console.ReadLine());
            int[,] arr2 = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr2[i, j] = random.Next(-10, 10);
                }
            }
            foreach (int element in arr2)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(arr2[i, j] + ", ");
                }
                Console.WriteLine();
            }

            int[][] arr3 = new int[N][];
            for(int i=0;i<N;i++)
            {
                int q = random.Next(1, 5);
                arr3[i] = new int[q];
            }


            String s1 = "Dina";
            String s2 = "Dina";
            if(s1==s2)
            {
                Console.WriteLine("равны");
            }
            int N = int.Parse(Console.ReadLine());
            int[] a1 = new int[N];
            Random r = new Random();

            int countMinus = 0, countPlus = 0;
            for(int i=0;i<N;i++)
            {
                a1[i] = r.Next(-10, 10);
                if(a1[i]>=0)
                {
                    countPlus++;
                }
                else
                {
                    countMinus++;
                }
            }*/

            int[] b = new int[7] { -1, -2, 3, 4, 5, 6, 7 };
            PrintArrayOnConsole(b);
            int r1 = CountOfNechet(b);
            int r2 = CountOfPolozhitel(b);


            Console.WriteLine("\n" + r1 + "\t" + r2);
        }
        static void Task6()
        {
            /*List<int> myList = new List<int>();
            Random random = new Random();
            myList.Add(random.Next(-10, 10));
            myList.Add(random.Next(-10, 10));
            myList.Add(random.Next(-10, 10));
            myList.Add(random.Next(-10, 10));
            myList.Add(random.Next(-10, 10));
            int countOfPolozhitel=0, countOfOtritatel = 0;
            foreach(int element in myList)
            {
                if(element>=0)
                {
                    countOfPolozhitel++;
                }
                else
                {
                    countOfOtritatel++;
                }
            }
            for(int i=0;i<myList.Count; i++)
            {
                if(myList[i] >= 0)
                {
                    countOfPolozhitel++;
                }
                else
                {
                    countOfOtritatel++;
                }
            }
            int[] a = new int[5];

            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    Name="A1",
                    Skill=1
                },
                new Player()
                {
                    Name="A2",
                    Skill=2
                }
            };
            players.Add(
                new Player()
                {
                    Name = "A3",
                    Skill = 3
                });

            Dictionary<string, List<int>> products = new Dictionary<string, List<int>>();
            products.Add("bread", new List<int>() { 5,4,2});
            products.Add("apple", new List<int>() { 5, 4 });

            ArrayList array = new ArrayList();
            array.Add("Привет");
            array.Add(5);
            array.Add(new Player());*/

        }
        static void Task7()
        {
            int[] a = new int[5];
            int[] b = new int[2];
            int[] c = new int[6];
            RandomInitialization(a);
            RandomInitialization(b);
            RandomInitialization(c);
            Console.WriteLine(SumAllElementsInArray(a) + SumAllElementsInArray(b) + SumAllElementsInArray(c));


            int y = -1, z;
            RandomInitializationRefOut(ref y, out z);

            ShowArray("Hello", "Bye", a);
            ShowArray("Hello", "Bye", 3, 4, 5, 6, 7, 8, 9, 10);
            ShowArray();
        }

        struct Person
        {
            public string name;
            public byte age;

            //конструктор
            public Person(string name, byte age2)
            {
                //this относится к структуре
                this.name = name;
                age = age2;
            }
            public Person(string name)
            {
                this.name = name;
                age = 10;
            }
            public void PrintOnConsole()
            {
                Console.WriteLine(name + "\t" + age);
            }

        }
        struct Point
        {
            private int x;
            private int y;

            //свойство
            public int X
            {
                get
                {
                    return x;
                }
                //запись
                set
                {
                    x = value;
                }
            }
            public int Y
            {
                //чтение
                get
                {
                    return y;
                }
            }

            public Point(int a, int b)
            {
                x = a;
                y = b;

            }
            public void Print()
            {
                Console.WriteLine(x + " " + y);
            }
        }
        enum WeekDay
        {
            Monday = 1, Tuesday, Wednesday, Thuirsday, Friday
        }
        static void AskNameAndSayHello()
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
        }
        static int Sum(int first, int second)
        {
            int result = first + second;

            return result;
        }
        struct StructA
        {
            public string text;
            public StructB Something(int ind)
            {
                StructB structB = new StructB();
                structB.sybmbol = text[ind];

                return structB;
            }
        }
        struct StructB
        {
            public char sybmbol;
        }
        struct Point3D
        {
            public int X;
            public int Y;
            public int Z;
            public void Print()
            {
                Console.WriteLine(X + " " + Y + " " + Z);
            }
            public void Print2(int d)
            {
                Console.WriteLine(X + d + " " + Y + d + " " + Z + d);
            }
        }
        static void PrintArrayOnConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int CountOfNechet(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result++;
                }
            }
            return result;
        }
        static int CountOfPolozhitel(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    result++;
                }
            }
            return result;
        }
        struct Player
        {
            public string Name;
            public int Skill;
        }

        public static void RandomInitialization(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
        }
        public static int SumAllElementsInArray(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
        public static void Add5(int[] array, int[] result)
        {
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] + 5;
            }
        }
        public static int RandomInitialization(int val1, int val2)
        {
            Random random = new Random();
            val1 = random.Next(0, 10);
            val2 = random.Next(0, 10);
            return val1;
        }
        public static void RandomInitialization(ref int val1, ref int val2)
        {
            Random random = new Random();
            val1 = random.Next(0, 10);
            val2 = random.Next(0, 10);
        }
        public static void RandomInitializationRefOut(ref int val1, out int val2)
        {
            Random random = new Random();
            val1 = random.Next(0, 10);
            val2 = random.Next(0, 10);
        }
        public static void ShowArray(String s, String s2, params int[] array)
        {
            Console.WriteLine("############" + s);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("############" + s2);
        }
        public static void ShowArray(params int[] array)
        {
            Console.WriteLine("############");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("############");
        }

        //занятие 13.03
        static void Task8()
        {
            //p1 - объект класса Student
            Student.DeveloperName = "Dina Latypova";

            Student s1 = new Student(5, "Ivan", "Ivanov");
            Student s2 = new Student("Petya", "Ivanov");

            Student s3 = new Student();
            s3.Name = "Dina";
            int q = s3.IdGetSet;
            s3.IdGetSet = 111;
            s3.ShowInfo();

            Console.WriteLine(s1.FullName);
        }
        static void Task9()
        {
            Bank bank1 = new Bank(1, 140.0, TypeBankAccount.Накопительный);
            bank1.PrintOnScreen();
            double suminDollar = bank1.GetSum / 70.0;
            Bank bank2 = new Bank(2, suminDollar, TypeBankAccount.Накопительный);
            bank2.PrintOnScreen('d');

            Smartphone apple = new Smartphone();
            apple.Name = "Iphone";
            apple.Call();
        }
        static void Task10()
        {
            Employer e = new Employer();
            e = Employer.LookupByName("Dina");  //в куче 2 объекта

            Employer e2 = Employer.LookupByName("qwerty");  //в куче 1 объект

            int a = 5;
            long q = a; //неявное приведение


            long w = 8888888888888888888;
            int t = (int)w; //явно

            ArrayList list = new ArrayList();


            try
            {
                int num1 = 1;
                int num2 = 1;
                int res = num1 / num2;
            }
            catch (DivideByZeroException eee)
            {
                Console.WriteLine(eee.Message);
            }
            catch (Exception eee)
            {
                Console.WriteLine(eee.Message);
            }
            finally
            {
                Console.WriteLine("Поделили");
            }
        }
        static void Task11()
        {
            Dog d1 = new Dog("Бобик");
            Dog d2 = new Dog("Глаша");
            Dog.Count = 9;
            Dog d3 = new Dog("Жулик");

            Message m = d3.Say;
            m += Hello;
            m += Bye;
            
            m();

            Message m2 = delegate ()
            {
                Console.Write("qwerty");
            };
            m2();

            Message m3 = () => { Console.Write("qwerty"); };




            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            var selectedPeople = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p=>p);

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

        }
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        static void Bye()
        {
            Console.WriteLine("Bye");
        }

        delegate void Message();
        static void Main(string[] args)
        {
            Task11();
            Console.ReadKey();
        }

      
    }
}
