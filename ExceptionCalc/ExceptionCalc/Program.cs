using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим и проверяем на корректность число X:
            Console.WriteLine("Введите значение X:");
            int x;               
                input1: string inputx = Console.ReadLine();
                if (Int32.TryParse(inputx, out x))
                {
                    Console.WriteLine("---------------");
                }
                else
                {
                    Console.WriteLine("Введите корректное число от 0 до ...");
                    goto input1;
                }
            // Вводим и проверяем на корректность число Y:
            Console.WriteLine("Введите значение Y:");
           int y;
                input2: string inputy = Console.ReadLine();
                if (Int32.TryParse(inputy, out y))
                {
                    Console.WriteLine("---------------");
                }
                else
                {
                    Console.WriteLine("Введите корректное число от 1 до ...");
                    goto input2;
                } 
            //Выбираем тип операции:
            Console.WriteLine("Введите тип желаемой операции: + или -, или *, или /");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Calculator.Add(x, y);
                    break;
                case "-":
                    Calculator.Sub(x, y);
                    break;
                case "*":
                    Calculator.Mul(x, y);
                    break;
                case "/":
                    Calculator.Div(x, y);
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            // Delay - Задержка
            Console.ReadKey();
        }
    }
    class Calculator
    {
        // Операция Сложения
        public static void Add(int x, int y)
        {
            //return x + y;
            Console.WriteLine("Результат: {0}", x + y);
        }
        // Операция Вычитания
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Результат: {0}", x - y);
        }
        // Операция Умножения
        public static void Mul(int x, int y)
        {
            Console.WriteLine("Результат: {0}", x * y);
        }
        // Операция Деления с проверкой деления на 0
        public static void Div(int x, int y)
        {
            if (y == 0)
            {
                try
                {
                    int rezult = x / y;
                    //return x / y;
                    //Console.WriteLine("Проверка деления на 0");
                    //Console.WriteLine("Результат деления: ", x/y);
                }
                catch (Exception ex) when (y == 0)
                {
                    Console.WriteLine("Y не должен быть равным 0. Ошибка: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Результат: {0}", x / y);
            }
        }
    }
}
