using System;
namespace App
{
    class App
    {
        static void Main(string[] args)
        {

            // SHARED PUBLIC ELEMENTS
            Console.WriteLine("Enter q (a prime number): ");
            ulong q = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Enter a (an integer): ");
            int a = Convert.ToInt32(Console.ReadLine());


            // PRIVATE KEYS
            Console.WriteLine("Enter the first private key of A \n Xa: ");
            ulong xA = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Xb: ");
            ulong xB = Convert.ToUInt64(Console.ReadLine());


            // PUBLIC KEYS
            ulong yA = (ulong) Math.Pow(a , xA) % q;
            Console.WriteLine($"Ya is {yA}");

            ulong yB = (ulong) Math.Pow(a , xB) % q;
            Console.WriteLine($"Yb is {yB}");


            // SHARED KEYS
            ulong kAB = (ulong) Math.Pow(yB , xA) % q;

            ulong kBA = (ulong) Math.Pow(yA , xB) % q;

            // CONSOLE OUTPUT
            Console.WriteLine(kAB);
            Console.WriteLine(kBA);

        }
    }
}