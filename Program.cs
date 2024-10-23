using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3AtP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter a natural number n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double sum = 0.0;

                for (int i = 1; i <= n; i++)
                {
                    sum += Math.Pow(-1, i + 1) / (2 * i - 1);
                }

                Console.WriteLine($"The sum of the series for n = {n}: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a natural number greater than 0.");
            }

            // task 2
            int k = 14;
            double X = Math.PI / 16;
            double epsilon = 1e-6;

            double S1 = 0;
            double an;
            int iterationCount = 0;

            Console.WriteLine("Iteration Number | Current Term   | Accumulated Sum | Error");
            Console.WriteLine("------------------------------------------------------------");

            do
            {
                an = Math.Pow(-1, iterationCount) / (Math.Pow(2, iterationCount) + iterationCount * X);

                S1 += an;

                double error = Math.Abs(an);

                Console.WriteLine($"{iterationCount,-15} | {an,-15:F10} | {S1,-15:F10} | {error,-10:F10}");

                iterationCount++;
            }
            while (Math.Abs(an) > epsilon);

            Console.WriteLine($"\nCalculated sum of the series S1 = {S1:F10}");

            // task 3
            double a = -6;
            double b = 1;
            double h = 0.2;

            Console.WriteLine("   x     |    y = arctan(x + 3.1)   |   z = e^x");
            Console.WriteLine("---------------------------------------------------");

            for (double x = a; x <= b; x += h)
            {
                double y = Math.Atan(x + 3.1);
                double z = Math.Exp(x);

                Console.WriteLine($"{x,-8:F2} | {y,-25:F10} | {z,-10:F10}");
            }
        }
    }
}
