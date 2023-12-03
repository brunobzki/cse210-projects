class Truck : Vehicle
{
    private double _loadCapacity;
    private string _tractionType;
    private static Fleet _fleet;

    public Truck(string brand, string model, int year, double mileage, string fuelType, double loadCapacity, string tractionType)
        : base(brand, model, year, mileage, fuelType)
    {
        _loadCapacity = loadCapacity;
        _tractionType = tractionType;
        _fleet = new Fleet();
    }

    public override void PerformService()
    {
        Console.WriteLine("Greasing components of the truck...");
        Console.WriteLine("Checking truck's load capacity...");
        Console.WriteLine("Checking truck engine...");
    }

    public override string GetDetails()
    {
        string baseDetails = base.GetDetails();
        return $"{baseDetails}, Load Capacity: {_loadCapacity}, Traction Type: {_tractionType}";
    }
}





