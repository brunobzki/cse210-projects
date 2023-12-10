class Fleet
{
    private List<Vehicle> vehicles;

    public Fleet()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Car vehicle)
    {
        vehicles.Add(vehicle);
    }
    public void AddTruck(Truck vehicle)
    {
        vehicles.Add(vehicle);
    }
    public List<Vehicle> GetVehicles()
    {
        return vehicles;
    }

    public void CreateNewVehicle()
    {
        Console.Clear();
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
        Console.Clear();
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
        newCar.PerformService();
        Console.WriteLine("Press Enter to go back to the menu.");
        Console.ReadLine();
    }

    private void AddNewTruck()
    {
        Console.Clear();
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
        Truck newTruck = new Truck(brand, model, year, mileage, fuelType, loadCapacity);
        AddTruck(newTruck);
        Console.WriteLine("New truck added to the fleet.");
        newTruck.PerformService();
        Console.WriteLine("Press Enter to go back to the menu.");
        Console.ReadLine();
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Information about the Fleet:");
        Console.WriteLine();
        if (vehicles.Count == 0)
        {
            Console.WriteLine("The fleet is empty.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to go back to the menu.");
            Console.ReadLine();
            return;
        }
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.Brand} {vehicle.Model}, Year: {vehicle.Year}, Mileage: {vehicle.Mileage}");
        }
        Console.WriteLine();
        Console.WriteLine("Press Enter to go back to the menu.");
        Console.ReadLine();
    }
    public void SaveVehiclesToFile(string filePathload)
    {
        using (StreamWriter writer = File.AppendText(filePathload))
        {
            foreach (Vehicle vehicle in vehicles)
            {
                string vehicleDetails = $"{vehicle.Brand},{vehicle.Model},{vehicle.Year},{vehicle.Mileage},{vehicle.FuelType}";
                writer.WriteLine(vehicleDetails);
            }
        }
    }
    public void LoadVehiclesFromFile(string filePathLoad)
    {
        if (!File.Exists(filePathLoad))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePathLoad))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] vehicleDetails = line.Split(',');
                    string brand = vehicleDetails[0];
                    string model = vehicleDetails[1];
                    int year = int.Parse(vehicleDetails[2]);
                    double mileage = double.Parse(vehicleDetails[3]);
                    string fuelType = vehicleDetails[4];
                    Vehicle car = new Vehicle(brand, model, year, mileage, fuelType);
                    vehicles.Add(car);
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading vehicles: {ex.Message}");
        }
    }
}