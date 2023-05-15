using System;
namespace  Practical_2
{
    class Customer_Account
    {
        private string bank_name;
        private long customer_accountNo;
        private string customer_name;
    
        public Customer_Account(long accountNo, string customerName)
        {
            bank_name = "BOB";
            customer_accountNo = accountNo;
            customer_name = customerName;
        }

        public void printInfo()
        {
            Console.WriteLine($"Bank Name : {bank_name}");
            Console.WriteLine($"Custome Account Number  : {customer_accountNo}");
            Console.WriteLine($"Custome Name : {customer_name}");
            Console.WriteLine("----------------------------------");
        }
    }


    class program
    {
        static void Main(string[] args)
        {
            Customer_Account customer1  = new Customer_Account(12345678910,"Abhay Chothani");
            Customer_Account customer2 = new Customer_Account(678910, "jay");
            Customer_Account customer3 = new Customer_Account(167822910, "parthiv");
            customer1.printInfo();
            customer2.printInfo();
            customer3.printInfo();
        }
    }
}