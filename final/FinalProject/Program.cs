

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        Mechanic mechanicInst = new Mechanic("", "");
        Reminder reminder = new Reminder();
        Fleet fleetManager = new Fleet();
        MaintenanceRecord maintenanceRecord = new MaintenanceRecord(date, "serviceType", 0, 0);
        List<Mechanic> mechanicsAvailable = mechanicInst.MechanicsList;
        List<Vehicle> vehiclesForMaintenance = fleetManager.GetVehicles();
        string filePath = "maintenance_records.txt";
        string filePathLoad = "vehicles.txt";
        fleetManager.LoadVehiclesFromFile(filePathLoad);

        while (true)
        {
            Console.Clear();
            ShowMenu();
            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Please enter a valid option.");

            }

            switch (option)
            {
                case 1:
                    fleetManager.CreateNewVehicle();
                    break;
                case 2:
                    fleetManager.DisplayInformation();
                    break;
                case 3:
                    reminder.CreateServiceReminder(fleetManager.GetVehicles());
                    break;
                case 4:
                    maintenanceRecord.RecordMaintenance(vehiclesForMaintenance, mechanicsAvailable);
                    maintenanceRecord.SaveMaintenanceRecord(filePath);
                    break;
                case 5:
                    Mechanic newMechanic = mechanicInst.CreateNewMechanic();
                    mechanicInst.AddMechanicToList(newMechanic);
                    break;
                case 6:
                    fleetManager.SaveVehiclesToFile(filePathLoad);
                    Console.WriteLine("Bye Bye");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    static void ShowMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create a vehicle");
        Console.WriteLine("2. See all vehicle");
        Console.WriteLine("3. Make a service reminder");
        Console.WriteLine("4. Record a mantenace (create a mechanic first)");
        Console.WriteLine("5. Create mechanics");
        Console.WriteLine("6. Exit");
        Console.Write("Select a option: ");
    }
}