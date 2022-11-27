using System;
namespace App
{
    public class RanGen
    {
        public static void ranGen()
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
            Console.WriteLine($"Ya = {yA}");

            long yB = (long) Math.Pow(a , xB) % q;
            Console.WriteLine($"Yb = {yB}");


            // SHARED KEYS
            long kAB = (long) Math.Pow(yB , xA) % q;
            kAB = Math.Abs(kAB);

            long kBA = (long) Math.Pow(yA , xB) % q;
            kBA = Math.Abs(kBA);

            // CONSOLE OUTPUT
            Console.WriteLine($"Kab = {kAB}");
            Console.WriteLine($"Kba = {kBA}");

        }
    }
}