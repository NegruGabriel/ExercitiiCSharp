using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            
            if (a % 2 == 0 )
            {
                Console.WriteLine("este par");
            }
            else
            {
                Console.WriteLine("este impar");
            }
           

        }
    }
}
