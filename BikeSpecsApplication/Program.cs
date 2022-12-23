/*// Console app that will claim information about a Bike
// The bike should have :  Brand , Model, age, Category, CC

Console.WriteLine("Menu");
Console.WriteLine("Select 1 To enter a New Entry.");
Console.WriteLine("Select 2 To see entries");

var menu = Console.ReadKey();

Console.WriteLine("");

Console.WriteLine($"You Select {menu.KeyChar}");
*/




using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add new entry ");
            Console.WriteLine("2) See the entries");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CaptureInput();
                    return true;
                case "2":
                   
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Clear();
            Console.Write("Enter the Brand of the bike : ");
            Console.ReadLine();
            Console.Write("Enter the Model of the bike : ");
            Console.ReadLine();
            Console.Write("Enter the Age of the bike : ");
            Console.ReadLine();
            Console.Write("Enter the Category of the bike : ");
            Console.ReadLine();
            Console.Write("Enter the CC of the bike : ");
            return Console.ReadLine();
        }
       
    }
}