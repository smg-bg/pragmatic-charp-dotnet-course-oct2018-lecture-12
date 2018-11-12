using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // this variable is declared so that we can pass it to 
            // string.Format(..), but we forgot it and we get a 
            // compile time warning and runtime exception
            var name = "Joro";

            try
            {
                try
                {
                    // we should be careful when showing exceptions to end users
                    // because they can expose sensitive information
                    // hint: you wrap exception in ApplicationException and then display
                    //       its message to the user, but not the inner exceptions' messages
                    // throw new SystemException("Your password is 1234");

                    // this will throw FormatException (e.g. name is not passed)
                    Console.WriteLine(string.Format("My name is {0}!"));

                    // this will NOT throw exception
                    // Console.WriteLine(string.Format("My name is {0}!", name));
                }

                // DO NOT DO THIS!!! Open catch is a bad practice!
                //catch
                //{
                //    Console.WriteLine("We have an exception. So what?");
                //}

                // DO NOT DO THIS!!! General catch is a bad practice!
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

                // we should order catch clauses from more concreete to more general exceptions
                catch (FormatException ex)
                {
                    Console.WriteLine($"There is problem with string " +
                        $"formatting: { ex.Message.Substring(0, 20) } ");

                    throw new ApplicationException("Something went wrong", ex);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Argument is expected!");
                }
                catch (SystemException ex)
                {
                    Console.WriteLine("Some system stuff went wrong!");

                    throw new ApplicationException("Opps! System went wrong", ex);
                }
                finally
                {
                    Console.WriteLine("We reached finally block...");
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
