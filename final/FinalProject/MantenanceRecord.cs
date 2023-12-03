class MaintenanceRecord
{
    private DateTime _date;
    private string _serviceType;
    private double _mileageAtService;
    private double _cost;

    public MaintenanceRecord(DateTime date, string serviceType, double mileageAtService, double cost)
    {
        _date = date;
        _serviceType = serviceType;
        _mileageAtService = mileageAtService;
        _cost = cost;
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
     public void RecordMaintenance(List<Vehicle> vehicles)
    {
        Console.WriteLine("Enter date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Please enter a valid date (yyyy-mm-dd): ");
        }

        Console.Write("Enter service type: ");
        string serviceType = Console.ReadLine();

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
        double mileageAtService;
        while (!double.TryParse(Console.ReadLine(), out mileageAtService))
        {
            Console.WriteLine("Please enter a valid mileage: ");
        }

        Console.Write("Enter cost: ");
        double cost;
        while (!double.TryParse(Console.ReadLine(), out cost))
        {
            Console.WriteLine("Please enter a valid cost: ");
        }

        MaintenanceRecord newMaintenanceRecord = new MaintenanceRecord(date, serviceType, mileageAtService, cost);
        newMaintenanceRecord.LogMaintenance(vehicles[vehicleIndex - 1]); 
    }

}
