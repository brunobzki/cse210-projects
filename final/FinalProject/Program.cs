class Program

{
    static void Main()
    {

        List<MaintenanceRecord> maintenanceRecords = new List<MaintenanceRecord>();

        List<Reminder> reminders = new List<Reminder>();
        Fleet fleetManager = new Fleet();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a vehicle");
            Console.WriteLine("2. See all vehicle");
            Console.WriteLine("3. Make a service reminder");
            Console.WriteLine("4. Record a mantenace");
            Console.WriteLine("5. Crete mechanics");
            Console.WriteLine("6. Exit");
            Console.Write("Select a option: ");

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Please enter a valid option.");
                continue;
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

                    break;
                case 4:
                    DateTime date = DateTime.Now;
                    string serviceType = "base";

                    List<Vehicle> vehiclesForMaintenance = fleetManager.GetVehicles();

                    MaintenanceRecord maintenanceRecord = new MaintenanceRecord(date, serviceType, 0, 0);
                    maintenanceRecord.RecordMaintenance(vehiclesForMaintenance);
                    string filePath = "maintenance_records.txt"; // Ruta del archivo donde se guardarán los registros
                    maintenanceRecord.SaveMaintenanceRecord(filePath);
                    break;
                case 5:

                    break;
                case 6:
                    Console.WriteLine("Bye Bye");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    public void DisplayInformation(Fleet fleet)
    {
        Console.WriteLine("Information about the Fleet:");

        List<Vehicle> vehicles = fleet.GetVehicles();


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

    public void ScheduleReminder(Reminder reminder)
    {

    }
}