using System;
namespace App
{
    class App 
    {  
       
        // MAIN METHOD
        static void Main(string[] args)
        {
            // METHOD SELECTION
            Console.WriteLine("------------------Diffie Hellman Key Encryption-------------- \n \n");
            Console.WriteLine("Would you like to generate random keys (1) or enter your own keys (2) ?");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RanGen.ranGen();
                    break;
                case 2:
                    UserIn.userIn();
                    break;
                default:
                    Console.WriteLine("Enter a suitable answer.");
                    break;
            }


        }

    }
}