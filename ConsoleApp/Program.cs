using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Lucas Rodgers";
            String country = "Canada";

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I live in " + country + "!" + '\n');


            DateTime date = DateTime.Today;
            Console.WriteLine("Today's date is " + date.ToString("D") + '\n');

            DateTime Christmas = new DateTime(2020, 12, 25);
            DateTime todayDate = DateTime.Today;
            Console.WriteLine("Days until Christmas!");
            Console.WriteLine(Christmas - todayDate);

            Console.WriteLine('\n' + "Window Material Calculator:");
            Console.WriteLine("Please enter the width of the Window in feet");
            String windowWidth = Console.ReadLine();
            double windowWidthNum = Convert.ToDouble(windowWidth);
            
            Console.WriteLine("Please enter the height of the Window in feet");
            String windowHeight = Console.ReadLine();            
            double windowHeightNum = Convert.ToDouble(windowHeight);
           
            double totalWood = (windowHeightNum + windowWidthNum) * 2;         
            double totalGlass = (windowHeightNum * windowWidthNum);
            Console.WriteLine("You will need " + totalWood + " feet of wood and two " + totalGlass + " square foot panes of glass ");
        }
    }
}
