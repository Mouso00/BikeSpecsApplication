/*// Console app that will claim information about a Bike
// The bike should have :  Brand , Model, age, Category, CC

Console.WriteLine("Menu");
Console.WriteLine("Select 1 To enter a New Entry.");
Console.WriteLine("Select 2 To see entries");

var menu = Console.ReadKey();

Console.WriteLine("");

Console.WriteLine($"You Select {menu.KeyChar}");
*/


//
namespace BikeSpecsApplication

{
    class BikeSpecsApplication
    {
        public static List<global::BikeSpecsApplication.Bike> bikeList { get; set; } = new List<global::BikeSpecsApplication.Bike>();
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
            Console.WriteLine("1) Add new bike ");
            Console.WriteLine("2) See the bike entries");
            Console.WriteLine("3) See the car entries");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CaptureInput();
                    return true;
                case "2":
                    showBikeList();
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

            var Bike = new global::BikeSpecsApplication.Bike();

            Console.Write("Enter the Brand of the bike : ");
            var brand = Console.ReadLine();
            Bike.Brand = brand;

            Console.Write("Enter the Model of the bike : ");
            var model = Console.ReadLine();
            Bike.Model = model;

            Console.Write("Enter the Age of the bike : ");
            var age = Console.ReadLine();
            Bike.Age = age;


            Console.Write("Enter the Category of the bike : ");
            var category = Console.ReadLine();
            Bike.Category = category;


            Console.Write("Enter the CC of the bike : ");
            var cc = Console.ReadLine();
            Bike.CC = cc;


            bikeList.Add(Bike);


        }
       
        public static void showBikeList()
        {
            Console.Clear();
            foreach (var bike in bikeList)
            {
                string brand = bike.Brand;
                string model = bike.Model;
                string age = bike.Age;
                string category = bike.Category;
                string cc = bike.CC;
                Console.Write("bike's brand : ",brand);
                Console.Write(" bike : model", model);
                Console.Write("bike age: ", age);
                Console.Write("bike category: ", category);
                Console.Write(" bike cc: ",cc);
                Console.Write("Next bike : ");
            }
            Console.ReadKey();


        }
        

    }
}

    
