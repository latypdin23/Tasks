using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    class Student
    {
        private int Id;
        public string Name;  //поле
        public string Surname;  //поле
        public int Age { get; set; } //автосвойство

        public static string DeveloperName;

        public string FullName
        {
            get //для чтения
            {
                return Name + " " + Surname;
            }
        }
        public int IdGetSet //свойство
        {
            get
            {
                return Id;
            }
            set //для записи
            {
                Id = value;
            }
        }

        public Student()
        {
            Name = "здесь должно быть имя";
        }
        public Student(int id,string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public Student(string name, string Surname)
        {
            Random r = new Random();
            Id = r.Next(-100,100);

            Name = name;
            this.Surname = Surname; //this - относится к текущему классу
        }
        public void ShowInfo()
        {
            Console.WriteLine("Id=" + Id);
        }
    }
}
