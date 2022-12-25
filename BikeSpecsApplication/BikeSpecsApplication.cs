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
            Console.WriteLine("1) Add new bike ");
            Console.WriteLine("2) Add new car");
            Console.WriteLine("3) See the bike entries");
            Console.WriteLine("4) See the car entries");
            Console.WriteLine("5) See the car and the bike entries");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            //waiting for user respond to continue
            switch (Console.ReadLine())
            {
                case "1":
                    CaptureBikeInput();
                    return true;
                case "2":
                   CaptureCarInput();
                    return true;
                case"3":
                    showBikeList();
                    return true;
                case "4":
                    showCarList();
                    return true;
                case "5":
                    showCarAndBikeList();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        //Capturing the bike kcharacteristics that the user will enter 
        public static void CaptureBikeInput()
        {
            Console.Clear();

            //initializng the Bike object in this method 
            var Bike = new global::BikeSpecsApplication.Bike();
            
            
            //waiting for the user entry and initializing it to the Bike object 
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

            
            // user entries and add it to the Bike object
            bikeList.Add(Bike);

        }

        //Capturing the car kcharacteristics that the user will enter
        public static void CaptureCarInput()
        {
            Console.Clear();

            var Car = new global::BikeSpecsApplication.Car();

            Console.Write("Enter the car Brand : ");
            var brand = Console.ReadLine();
            Car.Brand = brand;

            Console.Write("Enter the car Model : ");
            var model = Console.ReadLine();
            Car.Model = model;

            Console.Write("Enter the car Khm : ");
            var khm = Console.ReadLine();
            Car.Khm = khm;

            Console.Write("Enter the car Price : ");
            var price = Console.ReadLine();
            Car.Price = price;

            Console.Write("Enter the car Seats : ");
            var seats = Console.ReadLine();
            Car.Seats = seats;

            carList.Add(Car);


        }



       
        public static void showBikeList()
        {
            Console.Clear();
            // Running a loop that will collect every varriable bike in the bikeList
            foreach (var bike in bikeList)
            {
                string brand = bike.Brand;
                string model = bike.Model;
                string age = bike.Age;
                string category = bike.Category;
                string cc = bike.CC;

                //Printing message to the user according to the entries 
                Console.WriteLine("Bike brand:" + brand);
                Console.WriteLine("\nBike Model:" + model);
                Console.WriteLine("Bike age: " + age);
                Console.WriteLine("Bike category: " + category);
                Console.WriteLine("Bike cc: " + cc);
            }
            // Read so the program still Live till the user tap otherwise it will pop up and close directly
            Console.ReadKey();


        }
        public static void showCarList()
        {
            Console.Clear();
            // Running a loop that will collect every varriable car in the carList
            foreach (var car in carList)
            {
                string brand = car.Brand;
                string model = car.Model;
                string khm = car.Khm;
                string price = car.Price;
                string seats = car.Seats;

                //Printing message to the user according to the entries 
                Console.WriteLine("Car brand:" + brand);
                Console.WriteLine("\nCar Model:" + model);
                Console.WriteLine("Car age: " + khm );
                Console.WriteLine("Car category: " + price);
                Console.WriteLine("Car cc: " + seats);


            }
            Console.ReadKey();



        }
        public static void showCarAndBikeList() 
        {
        
            Console.Clear();

            foreach(var car in carList)
            {
                string brand = car.Brand;
                string model = car.Model;
                string khm = car.Khm;
                string price = car.Price;
                string seats = car.Seats;
                Console.WriteLine("Car brand:" + brand);
                Console.WriteLine("\nCar Model:" + model);
                Console.WriteLine("Car age: " + khm);
                Console.WriteLine("Car category: " + price);
                Console.WriteLine("Car cc: " + seats);
            }
            foreach(var bike in bikeList)
            {
                string brand = bike.Brand;
                string model = bike.Model;
                string age = bike.Age;
                string category = bike.Category;
                string cc = bike.CC;

                //Printing message to the user according to the entries 
                Console.WriteLine("Bike brand:" + brand);
                Console.WriteLine("\nBike Model:" + model);
                Console.WriteLine("Bike age: " + age);
                Console.WriteLine("Bike category: " + category);
                Console.WriteLine("Bike cc: " + cc);

            }
            Console.ReadKey();


        }
        

    }
}

    
