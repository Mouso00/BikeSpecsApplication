/*// Console app that will claim information about a Bike
// The bike should have :  Brand , Model, age, Category, CC

Console.WriteLine("Menu");
Console.WriteLine("Select 1 To enter a New Entry.");
Console.WriteLine("Select 2 To see entries");

var menu = Console.ReadKey();

Console.WriteLine("");

Console.WriteLine($"You Select {menu.KeyChar}");
*/


namespace BikeSpecsApplication

{
    class BikeSpecsApplication
    {

        //Initializing a global list for the Bike object 
        public static List<global::BikeSpecsApplication.Bike> bikeList { get; set; } = new List<global::BikeSpecsApplication.Bike>();

        //Initializing a global list for the Car object 
        public static List<global::BikeSpecsApplication.Car> carList { get; set; } = new List<global::BikeSpecsApplication.Car>();


        static void Main(string[] args)
        {
           //while loop to show a menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {

            // Main menu options 
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add new Car");
            Console.WriteLine("2) See the Car entries");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            //waiting for user respond to continue
            switch (Console.ReadLine())
            {
                case "1":
                    CaptureCarInput();
                    return true;
                case "2":
                    showCarList();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }


        //Capturing the car kcharacteristics that the user will enter
        public static void CaptureCarInput()
        {
            Console.Clear();

            var Car = new global::BikeSpecsApplication.Car();

            Console.Write("Enter the Car Maker : ");                var maker = Console.ReadLine(); Car.Maker = maker;

            Console.Write("Enter the Year of the Car Model : ");    var year = Console.ReadLine();  Car.Year = year;
            
            Console.Write("Enter the price of the Car : ");         var price = Console.ReadLine(); Car.Price = price;
            
            carList.Add(Car);
        }
        public static void showCarList()
        {
            Console.Clear();
            // Running a loop that will collect every varriable car in the carList
            foreach (var car in carList)
            {
                string maker = car.Maker;
                string year = car.Year;
                string price = car.Price;

                //Printing message to the user according to the entries 
                Console.ForegroundColor = ConsoleColor.Red; // Making the the next line with red color
                Console.WriteLine("\nCar Maker:" + maker);
                Console.ResetColor(); // To return colors back in normal

                Console.WriteLine("\nYear:" + year);
                Console.WriteLine("Price: " + price );
            }
            Console.ReadKey();
        }
    }
}

    
