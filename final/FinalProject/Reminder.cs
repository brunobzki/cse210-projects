class Reminder
{

    public void GenerateReminder(Vehicle vehicle)
    {
        Console.WriteLine($"Reminder generated for {vehicle.Brand} {vehicle.Model} next service at {vehicle.Mileage + 10000}.");
        Console.WriteLine();
        Console.WriteLine("Press Enter to go back to the menu.");
        Console.ReadLine();
    }

    public void CreateServiceReminder(List<Vehicle> vehiclesList)
    {
        int vehicleIndex = SelectVehicle(vehiclesList);
        GenerateReminder(vehiclesList[vehicleIndex - 1]);
    }

    private int SelectVehicle(List<Vehicle> vehiclesList)
    {
        int vehicleIndex;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a vehicle:");
            for (int i = 0; i < vehiclesList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vehiclesList[i].Brand} {vehiclesList[i].Model} {vehiclesList[i].Mileage}");
            }

            Console.Write("Enter the number of the vehicle: ");
            if (!int.TryParse(Console.ReadLine(), out vehicleIndex) || vehicleIndex < 1 || vehicleIndex > vehiclesList.Count)
            {
                Console.WriteLine("Invalid input. Please select a valid vehicle.");
                continue;
            }
            else
            {
                break;
            }
        }

        return vehicleIndex;
    }
}