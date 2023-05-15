using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.SRP
{



    internal class AfterSRP
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

            Employee employee = new Employee(name, designation, salary);
            EmployeeBonusCalculator bonusCalculator = new EmployeeBonusCalculator();
            double bonus = bonusCalculator.CalculateBonus(employee);

            EmployeeDetailsPrinter detailsPrinter = new EmployeeDetailsPrinter();
            detailsPrinter.PrintEmployeeDetails(employee, bonus);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string designation, double salary)
        {
            Name = name;
            Designation = designation;
            Salary = salary;
        }
    }

    public class EmployeeBonusCalculator
    {
        public double CalculateBonus(Employee employee)
        {
            double bonus = 0;
            if (employee.Designation == "Manager")
            {
                bonus = employee.Salary * 0.2;
            }
            else if (employee.Designation == "Developer")
            {
                bonus = employee.Salary * 0.1;
            }
            else if (employee.Designation == "Tester")
            {
                bonus = employee.Salary * 0.05;
            }

            return bonus;
        }
    }

    public class EmployeeDetailsPrinter
    {
        public void PrintEmployeeDetails(Employee employee, double bonus)
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Designation: {employee.Designation}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Bonus: {bonus}");
        }
    }


}
