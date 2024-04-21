using System;
using System.Runtime.CompilerServices;
using Unit_9_6_1_1;

namespace Unit91
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exception[] exception = new Exception[5];
            exception[0] = new OverflowException("Арифметическое, приведение или операция преобразования приводят к переполнению");
            exception[1] = new FormatException("Значение не находится в соответствующем формате для преобразования из строки методом преобразования");
            exception[2] = new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым.");
            exception[3] = new RankException("В метод передается массив с неправильным числом измерений.");
            exception[4] = new MyException("Сработало мое исключение");

            foreach (Exception ex in exception)
            {
                try
                {
                    throw ex;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (RankException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}

