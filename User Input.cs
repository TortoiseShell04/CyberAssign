using System;
namespace App
{
    public class UserIn
    {
        public static void userIn()
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
            System.Numerics.BigInteger kAB =  (System.Numerics.BigInteger)Math.Pow(yB , xA) % q;

            System.Numerics.BigInteger kBA =  (System.Numerics.BigInteger)Math.Pow(yA , xB) % q;

            // CONSOLE OUTPUT
            Console.WriteLine($"Kab = {kAB}");
            Console.WriteLine($"Kba = {kBA}");

        }
    }
}