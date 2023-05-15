using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3.Abstraction
{
    internal class Laptop
    {
        private string brand;
        private string model;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void LaptopDetails()

        {

            Console.WriteLine("Brand: " + Brand);

            Console.WriteLine("Model: " + Model);

        }
        private void MotherBoardInfo()

        {

            Console.WriteLine("MotherBoard Information");

        }
        public static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.Brand = "Apple";
            laptop.Model = "Apple MacBook Air";
            laptop.LaptopDetails();
            laptop.MotherBoardInfo();
        }
    }
}
