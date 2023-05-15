class Program
{
    public static int[] myArr = new int[5];

    static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 array elements");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter {i + 1} element: ");
            myArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("----------------------");
        try
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Index is {i} : value is {myArr[i]}");
                
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is finally block.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}   