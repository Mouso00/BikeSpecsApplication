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
       // public static List<global::BikeSpecsApplication.Bike> bikeList { get; set; } = new .List<global::BikeSpecsApplication.Bike>();

        //Initializing a global list for the Car object 
        public static List<Vehicle> vehicleList { get; set; } = new List<Vehicle>();
        public static List<Car> carList { get; set; } = new List<Car>();
        public static List<Airplane> airplaneList { get; set; } = new List<Airplane>();


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
            Console.WriteLine("2) Add new Plane");
            Console.WriteLine("3) See the Car entries");
            Console.WriteLine("4) See the Plane entries");
            Console.WriteLine("5) See all Vehicle entries");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            //waiting for user respond to continue
            switch (Console.ReadLine())
            {
                case "1":
                    captureCarInput();
                    return true;
                case "2":
                    capturePlaneInput();
                    return true;
                case "3":
                    showCarList();
                    return true;
                case "4":
                    showPlaneList();
                    return true;
                case "5":
                    showAllVehicleList();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }


        //Capturing the car characteristics that the user will enter
        public static void captureCarInput()
        {
            Console.Clear();

            Car Car = new Car();

            Console.Write("Enter the Car Maker : ");                
            var maker = Console.ReadLine();
            Car.maker = maker;

            Console.Write("Enter the Year of the Car Model : ");   
            var year = Console.ReadLine();
            Car.year = year;
            
            Console.Write("Enter the price of the Car : ");         
            var price = Console.ReadLine(); 
            Car.price = price;

            Console.Write("Enter the speed of the Car : ");
            var speed = Console.ReadLine();
            Car.speed = speed;

            carList.Add(Car);
            vehicleList.Add(Car);
        }
        public static void showCarList()
        {
            Console.Clear();
            // Running a loop that will collect every varriable car in the carList
            foreach (var car in carList)
            {
                string maker = car.maker;
                string year = car.year;
                string price = car.price;
                string speed = car.speed;
                //Printing message to the user according to the entries 
                Console.ForegroundColor = ConsoleColor.Red; // Making the the next line with red color
                Console.WriteLine("\nCar Maker:" + maker);
                Console.ResetColor(); // To return colors back in normal

                Console.WriteLine("\nYear:" + year);
                Console.WriteLine("Price: " + price );
                Console.WriteLine("Speed: " + speed);

            }
            Console.ReadKey();
        }
        public static void capturePlaneInput()
        {
            Console.Clear();

            Airplane Airplane = new Airplane();

            Console.Write("Enter the Maker Plane: ");
            var maker = Console.ReadLine();
            Airplane.maker = maker;

            Console.Write("Enter the Year of the Plane Model : ");
            var year = Console.ReadLine();
            Airplane.year = year;

            Console.Write("Enter the price of the Plane : ");
            var price = Console.ReadLine();
            Airplane.price = price;
            Console.Write("Enter the type of the Plane ");
            var planeType = Console.ReadLine();
            Airplane.planeType = planeType;


            airplaneList.Add(Airplane);
            vehicleList.Add(Airplane);
        }
        public static void showPlaneList()
        {
            Console.Clear();
            // Running a loop that will collect every varriable car in the carList
            foreach (var plane in airplaneList)
            {
                string maker = plane.maker;
                string year = plane.year;
                string price = plane.price;
                string planeType = plane.planeType;

                //Printing message to the user according to the entries 
                Console.ForegroundColor = ConsoleColor.Red; // Making the the next line with red color
                Console.WriteLine("\nPlane Maker:" + maker);
                Console.ResetColor(); // To return colors back in normal
                
                Console.WriteLine("\nYear:" + year);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Plane Type " + planeType);
            }
            Console.ReadKey();
        }
        public static void showAllVehicleList()
        {
            Console.Clear();

            // Running a loop that will collect every varriable car in the carList
            foreach (var vehicle in vehicleList)
            {
                string maker = vehicle.maker;
                string year = vehicle.year;
                string price = vehicle.price;

                //Printing message to the user according to the entries 
                Console.ForegroundColor = ConsoleColor.Red; // Making the the next line with red color
                Console.WriteLine("\nCar Maker:" + maker);
                Console.ResetColor(); // To return colors back in normal

                Console.WriteLine("\nYear:" + year);
                Console.WriteLine("Price: " + price);
            }
            Console.ReadKey();
        }
    }
}

    
