using System;
namespace  Practical_2
{
    class CustomerAccount
    {
        private string bank_name;
        private long customer_accountNo;
        private string customer_name;
    
        public CustomerAccount(long accountNo, string customerName)
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
            CustomerAccount customer1  = new CustomerAccount(12345678910,"Abhay Chothani");
            CustomerAccount customer2 = new CustomerAccount(678910, "jay");
            CustomerAccount customer3 = new CustomerAccount(167822910, "parthiv");
            customer1.printInfo();
            customer2.printInfo();
            customer3.printInfo();
        }
    }
}