using System;

namespace OperatiiNrRealeF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());

            Console.Write("c=");
            float c = float.Parse(Console.ReadLine());

            Console.Write("d=");
            float d = float.Parse(Console.ReadLine());

            float sum = (a + b + c + d);
            Console.WriteLine($"sum is {sum}");

            Console.WriteLine($" b - b = {b - b}");
            Console.WriteLine($" c - a ={c - a}");
            Console.WriteLine($" d - b = {d - b}");
            Console.WriteLine($" b - c - a = {b - c - a}");
            Console.WriteLine($" d - b - c- a = { d - b - c - a}");

            float prod = (a * b * c * d);
            Console.WriteLine($"prod is {prod}");

            Console.WriteLine($" c / c ={c / c} rest {c % c}");
            Console.WriteLine($" d / a ={d / a} rest {d % a}");
            Console.WriteLine($" b / d ={b / d} rest {b % d}");
            Console.WriteLine($" a / c ={a / c} rest {a % c}");
            Console.WriteLine($" d / a / b = {d / a / b} rest {d % a % b}");
            Console.WriteLine($" a/ c / d ={a / c / d} rest {a % c % d}");
            Console.WriteLine($" c / a / b / d ={c / a / b / d} rest {c % a % b % d}");
            Console.WriteLine($" d / b ={d / b}");
            Console.WriteLine($" d % a ={d % a}");
            Console.WriteLine($" c * a / b - d ={c * a / b - d}");


        }
    }
}
