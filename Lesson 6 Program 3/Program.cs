using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано линейное уравнение стандартного вида: A*X+B=C.");

            string A, B, C, X;

            Console.WriteLine("Задайте число 'A':");
            A = Console.ReadLine();

            Console.WriteLine("Задайте число 'B':");
            B = Console.ReadLine();

            Console.WriteLine("Задайте число 'C':");
            C = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int c = Convert.ToInt32(C);

            int x = (c - b) / a;

            X = "Ответ: X=" + x;

            Console.WriteLine(X);

            Console.ReadLine();
        }
    }
}
