using System;

namespace _4._3
{
    class Program
    {
        class MainPerson
        {
            private string _name;
            private string _surname;

            public MainPerson()
            {
                _name = "Вася";
                _surname = "Пупкин";
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Имя: {_name}");
                Console.WriteLine($"Фамилия: {_surname}");
                
            }
        }
        class Sub : MainPerson
        {
            private string _typeOfHome;
            private string _city;

            public Sub()
            {
                _typeOfHome = "Квартира";
                _city = "Киев";
            }

            public override void GetInfo()
            {
                
                base.GetInfo();
                Console.WriteLine($"Тип дома: {_typeOfHome}");
                Console.WriteLine($"Город: {_city}");
            }
        }
        static void Main(string[] args)
        {
            MainPerson main = new MainPerson();
            Sub sub = new Sub();
            main.GetInfo();
            Console.WriteLine("");
            sub.GetInfo();
        }
    }
}
