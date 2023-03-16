using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_11_2022
{
    enum TypeBankAccount
    {
        Накопительный,
        Валютный
    }
    //по умолчанию у классов internal
    class Bank
    {
        //по умолчанию у элементов private
        public long Id;
        private double Sum;
        public TypeBankAccount TypeBank { get; set; } //автосвойство
        
        public Bank()
        {

        }
        public Bank(long Id,double Sum, TypeBankAccount typeBank)
        {
            this.Id = Id;
            this.Sum = Sum;
            TypeBank = typeBank;
        }

        public double GetSum
        {
            get
            {
                return Sum;
            }
        }
        /// <summary>
        /// Конвертирует сумму в доллары по введенному курсу
        /// </summary>
        /// <param name="kursDollar"></param>
        /// <returns></returns>
        public double ConvertToDollar(double kursDollar)
        {
            return (double)(Sum / kursDollar);
        }
        //Перегрузка
        public void PrintOnScreen()
        {
            Console.WriteLine("Счет номер {0}, тип: {1}, баланс: {2} рублей", Id, TypeBank, Sum);
        }
        public void PrintOnScreen(char d)
        {
            Console.WriteLine("Счет номер {0}, тип: {1}, баланс: {2} долларов", Id, TypeBank, Sum);
        }
    }
}
