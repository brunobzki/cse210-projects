class MaintenanceRecord
{
    private DateTime _date;
    private string _serviceType;
    private double _mileageAtService;
    private double _cost;

    public DateTime date { get; internal set; }

    public MaintenanceRecord(DateTime date, string serviceType, double mileageAtService, double cost)
    {
        _date = date;
        _serviceType = serviceType;
        _mileageAtService = mileageAtService;
        _cost = cost;
    }

    public string GetMaintenanceDetails()
    {

        return $"Date: {_date}, Service Type: {_serviceType}, Mileage at Service: {_mileageAtService}, Cost: {_cost}";
    }

    public void LogMaintenance(Vehicle vehicle)
    {

        Console.WriteLine($"Maintenance logged for {vehicle.Brand} {vehicle.Model} on {_date}");
        Console.WriteLine($"Service Type: {_serviceType}, Mileage at Service: {_mileageAtService}, Cost: {_cost}");
    }

    public void SaveMaintenanceRecord(string filePath)
    {
        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine($"Maintenance Details - Date: {_date}, Service Type: {_serviceType}, Mileage at Service: {_mileageAtService}, Cost: {_cost}");
        }
    }

    public void RecordMaintenance(List<Vehicle> vehicles, List<Mechanic> mechanicsList)
    {
        Console.Clear();
        Console.WriteLine("Enter date (yyyy-mm-dd): ");
        while (!DateTime.TryParse(Console.ReadLine(), out _date))
        {
            Console.WriteLine("Please enter a valid date (yyyy-mm-dd): ");
        }
        Console.Write("Enter service type: ");
        _serviceType = Console.ReadLine();
        Console.WriteLine("Select a vehicle to record maintenance:");
        for (int i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {vehicles[i].Brand} {vehicles[i].Model}");
        }
        int vehicleIndex;
        while (!int.TryParse(Console.ReadLine(), out vehicleIndex) || vehicleIndex < 1 || vehicleIndex > vehicles.Count)
        {
            Console.WriteLine("Please enter a valid vehicle number: ");
        }
        Console.Write("Enter mileage at service: ");
        while (!double.TryParse(Console.ReadLine(), out _mileageAtService))
        {
            Console.WriteLine("Please enter a valid mileage: ");
        }
        Console.Write("Enter cost: ");
        while (!double.TryParse(Console.ReadLine(), out _cost))
        {
            Console.WriteLine("Please enter a valid cost: ");
        }
        Vehicle selectedVehicle = vehicles[vehicleIndex - 1];
        double previousMileage = selectedVehicle.Mileage;
        Console.WriteLine("Available Mechanics:");
        for (int i = 0; i < mechanicsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {mechanicsList[i].Name} ({mechanicsList[i].Specialty})");
        }
        Console.Write("Select a mechanic by entering the number: ");
        int selectedMechanicIndex;
        while (!int.TryParse(Console.ReadLine(), out selectedMechanicIndex) ||
                selectedMechanicIndex < 1 || selectedMechanicIndex > mechanicsList.Count)
        {
            Console.WriteLine("Invalid input. Please select a valid mechanic.");
            Console.Write("Select a mechanic by entering the number: ");
        }
        Mechanic selectedMechanic = mechanicsList[selectedMechanicIndex - 1];
        selectedMechanic.AssignTask();
        selectedVehicle.UpdateMileage(_mileageAtService);
        LogMaintenance(selectedVehicle);
        SaveMaintenanceRecord("maintenance_records.txt");
        Console.WriteLine();
        Console.WriteLine($"Mileage for {selectedVehicle.Brand} {selectedVehicle.Model} updated from {previousMileage} to {_mileageAtService}");
    }
}
