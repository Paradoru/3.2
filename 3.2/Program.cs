using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                b = 1;
                Console.WriteLine("Вводите числа, чтобы подсчитать введите (0)");
                while (true)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a == 0) break;  
                    b *= a;
                }
                if (a == 0 && b == 1) Console.WriteLine("Пожалуйста, введите хотя бы одно число");
                else
                Console.WriteLine($"Произведение последовательности чисел равно {b}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
