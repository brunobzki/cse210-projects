class Fleet
{
    private List<Vehicle> vehicles;

    public Fleet()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public List<Vehicle> GetVehicles()
    {
        return vehicles;
    }

    public void CreateNewVehicle()
    {
        Console.WriteLine("Select the type of Vehicle: ");
        Console.WriteLine("Option 1: CAR");
        Console.WriteLine("Option 2: TRUCK");

        int option;
        if (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine("Please enter a valid option.");
            return;
        }

        switch (option)
        {
            case 1:
                AddNewCar();
                break;
            case 2:
                AddNewTruck();
                break;
            default:
                Console.WriteLine("Invalid option. Please enter again.");
                break;
        }
    }

    private void AddNewCar()
    {
        Console.WriteLine("Creating a new car...");
        Console.Write("Enter brand: ");
        string brand = Console.ReadLine();
        Console.Write("Enter model: ");
        string model = Console.ReadLine();
        Console.Write("Enter year: ");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Please enter a valid year:");
        }
        Console.Write("Enter mileage: ");
        double mileage;
        while (!double.TryParse(Console.ReadLine(), out mileage))
        {
            Console.WriteLine("Please enter a valid mileage:");
        }
        Console.Write("Enter fuel type: ");
        string fuelType = Console.ReadLine();
        Console.Write("Enter the number of doors: ");
        int numberOfDoors;
        while (!int.TryParse(Console.ReadLine(), out numberOfDoors))
        {
            Console.WriteLine("Please enter a number:");
        }
        Console.Write("Enter the transmission type: ");
        string transmissionType = Console.ReadLine();

        Car newCar = new Car(brand, model, year, mileage, fuelType, numberOfDoors, transmissionType);
        AddVehicle(newCar);
        Console.WriteLine("New car added to the fleet.");
    }

    private void AddNewTruck()
    {
        Console.WriteLine("Creating a new truck...");
        Console.Write("Enter brand: ");
        string brand = Console.ReadLine();
        Console.Write("Enter model: ");
        string model = Console.ReadLine();
        Console.Write("Enter year: ");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Please enter a valid year:");
        }
        Console.Write("Enter mileage: ");
        double mileage;
        while (!double.TryParse(Console.ReadLine(), out mileage))
        {
            Console.WriteLine("Please enter a valid mileage:");
        }
        Console.Write("Enter fuel type: ");
        string fuelType = Console.ReadLine();
        Console.Write("Enter the load capacity: ");
        int loadCapacity;
        while (!int.TryParse(Console.ReadLine(), out loadCapacity))
        {
            Console.WriteLine("Please enter a number:");
        }
        Console.Write("Enter the traction type: ");
        string tractionType = Console.ReadLine();

        Truck newTruck = new Truck(brand, model, year, mileage, fuelType, loadCapacity, tractionType);
        AddVehicle(newTruck);
        Console.WriteLine("New truck added to the fleet.");
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Information about the Fleet:");

        if (vehicles.Count == 0)
        {
            Console.WriteLine("The fleet is empty.");
            return;
        }

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.Brand} {vehicle.Model}, Year: {vehicle.Year}, Mileage: {vehicle.Mileage}");
        }
    }
}