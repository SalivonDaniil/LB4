using System;


namespace _4._2
{
    class Program
    {
        
        class B
        {
            private string _text;
            public string text
            {
                get
                {
                    return _text;
                }
                set
                {
                    _text = value;
                }
            }
            public void GetInfo()
            {
                Console.WriteLine(text);
            }
        }
        class C : B
        {
            
            
        }
        class D : B
        {
            
        }
        class E : B
        {
            
        }
        static void Main(string[] args)
        {
            
            C c = new C();
            D d = new D();
            E e = new E();
            c.text = Console.ReadLine();
            d.text = Console.ReadLine();
            e.text = Console.ReadLine();
            Console.WriteLine("");
            c.GetInfo();
            d.GetInfo();
            e.GetInfo();
        }
    }
}
