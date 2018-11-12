using System;

namespace ExceptionDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new PragmaticException("My error message");

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
