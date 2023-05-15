using System;
namespace DebuggingApplication
{
    class program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any name : ");

            string userResponse = Console.ReadLine();

            if (Convert.ToBoolean(int.Parse(userResponse)))
            {

                Console.WriteLine("The entered value is a integer");

            }
        }
    }
}