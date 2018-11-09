using System;

namespace ThrowingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new ApplicationException("Your trial has expired!");

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
