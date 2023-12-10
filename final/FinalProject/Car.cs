class Car : Vehicle
{
    private int _numberOfDoors;
    private string _transmissionType;
    private static Fleet _fleet;

    public Car(string brand, string model, int year, double mileage, string fuelType, int numberOfDoors, string transmissionType)
        : base(brand, model, year, mileage, fuelType)
    {
        _numberOfDoors = numberOfDoors;
        _transmissionType = transmissionType;
        _fleet = new Fleet();
    }
    public override void PerformService()
    {
        Console.WriteLine();
        Console.WriteLine("Check ligths of the car...");
        Console.WriteLine("Check oil level...");
        Console.WriteLine("Check tires levels...");
        Console.WriteLine();
    }

}
