using System;

namespace OperatiiNrIntregi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());

            int sum = a + b + c + d;
            Console.WriteLine($"sum is {sum}");


            Console.WriteLine($"b - a - c - d = {b - a - c - d}");
            Console.WriteLine($"a - b - d - c = {a - b - d - c}");
            Console.WriteLine($"d - c - a - b = {d - c - a - b}");
            Console.WriteLine($"c - d - b - a = {c - d - b - a}");
            Console.WriteLine($"b - c - d - a = {b - c - d - a}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a - c = {a - c}");
            Console.WriteLine($"a - d = {a - d}");
            Console.WriteLine($"a - a = {a - a}");
            Console.WriteLine($"b - c = {b - c}");

            int prod = b * a * c * d;
            Console.WriteLine($"prod is {prod}");

            int div = a / b;
            int div1 = c / d;
            int div2 = d / a;
            int div3 = b / d;

            int div4 = a % c;
            int div5 = b % a;
            int div6 = c % a;
            int div7 = d % c;

            Console.WriteLine($"a / b = {div} rest {a % b}");
            Console.WriteLine($"c / d = {div1} rest {c % d}");
            Console.WriteLine($"d / a = {div2} rest {d % a}");
            Console.WriteLine($"b / d = {div3} rest {b % d}");
            Console.WriteLine($"a % c = {div4}");
            Console.WriteLine($"b % a = {div5}");
            Console.WriteLine($"c % a = {div6}");
            Console.WriteLine($"d % c = {div7}");



        }
    }
}
