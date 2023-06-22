using System;
namespace Calculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Enter First Number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The sum of the [" + num1 + "] and [" + num2 + "] is -> " + (num1 + num2));
                Console.WriteLine("The subtraction of [" + num1 + "] and [" + num2 + "] is -> " + (num1 - num2));
                Console.WriteLine("The multiplication of [" + num1 + "] and [" + num2 + "] is -> " + (num1 * num2));
                Console.WriteLine("The division of [" + num1 + "] and [" + num2 + "] is -> " + (num1 / num2));
            }
            catch(Ecxeption ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
