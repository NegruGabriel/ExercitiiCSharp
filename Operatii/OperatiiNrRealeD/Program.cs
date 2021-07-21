using System;

namespace OperatiiNrReale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());

            Console.Write("d=");
            double d = double.Parse(Console.ReadLine());

            double sum = (a + b + c + d);
            Console.WriteLine($"sum is {sum}");

            Console.WriteLine($"a - a = {a - a}");
            Console.WriteLine($"a - d = {a - d}");
            Console.WriteLine($"b - c = {b - c}");
            Console.WriteLine($"c - d = {c - d}");
            Console.WriteLine($"d - b = { d - b}");
            Console.WriteLine($"a - b - c = {a - b - c}");
            Console.WriteLine($"d - a - c = {d - a - c}");
            Console.WriteLine($"a - b - c - d = { a - b - c - d}");
            Console.WriteLine($"b - d - c - a = {b - d - c - a}");
            Console.WriteLine($"c - d - b - a = {c - d - b - a}");
            Console.WriteLine($"d - c - a - b  = {d - c - a - b}");

            double prod = a * d * c * b;
            Console.WriteLine($"prod = {prod}");

            Console.WriteLine($" a / b = {a / b}");
            Console.WriteLine($" b / b = {b / b}");
            Console.WriteLine($" c / d = {c / d}");
            Console.WriteLine($" d / a = {d / a}");
            Console.WriteLine($" c % d = { c % d}");
            Console.WriteLine($" b / a / c = {b / a / c}");
            Console.WriteLine($" b % a % c = {b % a % c}");
            Console.WriteLine($" d / a / b / c = {d / a / b / c}");
            Console.WriteLine($" d % a % b % c = {d % a % b % c}");

            Console.WriteLine($" a * b + c - d = { a * b + c - d}");
            Console.WriteLine($" d / c + b - a ={d / c + b - a} ");
            Console.WriteLine($"b / a * c % d = {b / a * c % d}");

        }
    }
}
