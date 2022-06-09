using System;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, Вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста, введите число или введите 'q' для выхода из программы");

            string S = Console.ReadLine();

            if (S == "q")
            {
                return;
            }


            int M = Int32.Parse(S);

            int c1 = 1;
            int c2 = 0;
            int c3 = 0;

            for (int i = 1; i <= M; i++)
            {
                c1 = c1 * i;
                c2 = c2 + i;

                if (i % 2 == 0)
                {
                    c3 = i;
                }
            }
            Console.WriteLine("Факториал равен  " + c1);
            Console.WriteLine("Сумма чисел от 1 до " + S + " = " + c2);

            Console.WriteLine("Максимальное четное число, меньше " + S + ", равно " + c3);
            Console.ReadLine();
        }
    }
}
