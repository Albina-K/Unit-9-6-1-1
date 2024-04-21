using System;
using System.Runtime.CompilerServices;
using Unit_9_6_1_1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Unit91
{
    public class Program
    {        
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEneteredEvent += ShowNumber;
            try
            {
                numberReader.Read();
            }
            catch (MyException)
            {
                Console.WriteLine("Введено неккоректное значение");
            }
        }

        static void ShowNumber(int number)
        {
            List<string> name = new List<string> { "ААА", "БББ", "ВВВ", "ГГГ", "ДДД", };
            switch (number)
            {
                case 1:
                    name.Sort();
                    foreach (string s in name)
                        Console.WriteLine(s);
                    break;
                case 2:
                    name.Reverse();
                    foreach (string s in name)
                        Console.WriteLine(s);
                    break;
            }
        }

        public class NumberReader
        {
            public delegate void NumberEneteredDelegate(int number);
            public event NumberEneteredDelegate NumberEneteredEvent;
            public void Read()
            {
                Console.WriteLine();
                Console.WriteLine("Ведите значение 1 для сортировки от А до Я или введите значение 2 для сортировки от Я до А");

                int number = Convert.ToInt32(Console.ReadLine());

                if (number != 1 && number != 2) throw new MyException();

                NumberEntered(number);
            }

            protected virtual void NumberEntered(int number)
            {
                NumberEneteredEvent?.Invoke(number);
            }
        }
    }
}