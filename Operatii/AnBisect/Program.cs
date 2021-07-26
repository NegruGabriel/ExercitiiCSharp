using System;

namespace AnBisect
{
    class Program
    {
        // Se citeste un numar intreg (an) de la tastatura.
        // Daca anul este bisect (anul e divizibil cu 4), se va afisa la consola mesajul "Anul {an} este bisect".
        // Daca anul nu e bisect, se va afisa la consola mesajul "Anul {an} nu este bisect"
        static void Main(string[] args)
        {
            Console.Write("an=");
            int an = int.Parse(Console.ReadLine());

            bool isLeapYear = (an % 4 == 0);

            if (isLeapYear == true)
            {
                Console.WriteLine($"Anul {an} este bisect");
            }
            else
            {
                Console.WriteLine($"Anul {an} nu este bisect");
            }
        }
    }
}
