using System;

namespace ThrowingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new ApplicationException("Insufficient memory on the server!", 
                new OutOfMemoryException("Your phisical memory is only 32 GB"));

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
