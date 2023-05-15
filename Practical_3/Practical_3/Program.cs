using Practical_3.Abstraction;
using Practical_3.Inheritance;
using Practical_3.Polymorphism;


class Program
{
    public static void Main(string[] args)
    {
        //Inheritance
        
        Team team = new Team();
        team.TeamName = "Test";
        //string teamDetails =
        team.printInfo();

        //Abstraction
        //Laptop laptop = new Laptop();
        //laptop.Brand = "Apple";
        //laptop.Model = "Apple MacBook Air";
        //laptop.LaptopDetails();


        //Polymorphism
        Bird myBird = new Bird();
        Duck myDuck = new Duck();
        myBird.Voice();
        myDuck.Voice();




    }
}