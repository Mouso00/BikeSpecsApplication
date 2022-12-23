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
using System.Diagnostics.Contracts;

namespace StringManipulation
{
    class Program
    {
        public static List<String> userList { get; set; } = new List<String>();
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
                    ShowList();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        public static void CaptureInput()
        {
            Console.Clear();
            Console.Write("Enter the Brand of the bike : ");
            var brand = Console.ReadLine(); 
            userList.Add(brand);
            Console.Write("Enter the Model of the bike : ");
            var model = Console.ReadLine();
            userList.Add(model);
            Console.Write("Enter the Age of the bike : ");
            var age = Console.ReadLine();
            userList.Add(age);
            Console.Write("Enter the Category of the bike : ");
            var category = Console.ReadLine();
            userList.Add(category);
            Console.Write("Enter the CC of the bike : ");
            Console.ReadLine() ;

           
      /*  public static string StoreInput()
        {
            String input = Console.ReadLine();
            List<String> userList = new List<String>();
            userList.Add(input);

      
            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }*/



        }
       
        public static void ShowList()
        {
            Console.Clear();
            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }
            Console.ReadKey();


        }
        

    }
}

    
