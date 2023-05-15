using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.SRP
{
    internal class BeforeSRP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Management System!");
            Console.WriteLine("Please enter the employee details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Designation: ");
            string designation = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            //Calculate Bonus
            double bonus = 0;
            if (designation == "Manager")
            {
                bonus = salary * 0.2;
            }
            else if (designation == "Developer")
            {
                bonus = salary * 0.1;
            }
            else if (designation == "Tester")
            {
                bonus = salary * 0.05;
            }

            //Print Employee Details
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Designation: {designation}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Bonus: {bonus}");

            Console.ReadLine();
        }
    } 
}


