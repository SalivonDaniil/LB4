using System;


namespace _4._1
{
    class Main
    {
        private string _mainString;
        private Type _type;

        public string mainString
        {
            get
            {
                return _mainString;
            }
            set
            {
                this._mainString = value;
            }
        }
        public Type type
        {
            get
            {
                return _type;
            }
            set
            {
                this._type = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Предложение: {mainString}, тип переменной: {type}");
        }
    }
    class Sub : Main
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Main main = new Main();
            Console.WriteLine("Введите предложение 1: ");
            main.mainString = Console.ReadLine();
            main.type = main.mainString.GetType();
            main.GetInfo();
            Sub sub = new Sub();
            Console.WriteLine("Введите предложение 2: ");
            sub.mainString = Console.ReadLine();
            sub.type = sub.mainString.GetType();
            sub.GetInfo();
        }
    }
}
