using System;
namespace App
{
    class App
    {
        static void Main(string[] args)
        {

            // SHARED PUBLIC ELEMENTS
            Console.WriteLine("Enter q (a prime number): ");
            long q = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter a (an integer): ");
            int a = Convert.ToInt32(Console.ReadLine());


            // PRIVATE KEYS
            Random key = new Random();
            long xA = key.Next((int) q);
            long xB = key.Next((int) q);


            // PUBLIC KEYS
            long yA = (long) Math.Pow(a , xA) % q;
            long yB = (long) Math.Pow(a , xB) % q;


            // SHARED KEYS
            long kAB = (long) Math.Pow(yB , xA) % q;
            kAB = Math.Abs(kAB);

            long kBA = (long) Math.Pow(yA , xB) % q;
            kBA = Math.Abs(kBA);

            // CONSOLE OUTPUT
            Console.WriteLine(kAB);
            Console.WriteLine(kBA);

        }
    }
}