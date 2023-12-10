class Vehicle
{
    private string _brand;
    private string _model;
    private int _year;
    private double _mileage;
    private string _fuelType;

    public Vehicle(string brand, string model, int year, double mileage, string fuelType)
    {
        _brand = brand;
        _model = model;
        _year = year;
        _mileage = mileage;
        _fuelType = fuelType;
    }

    public virtual void PerformService()
    {

    }
    public virtual void addNewVehicle()
    {

    }
    public void UpdateMileage(double newMileage)
    {
        _mileage = newMileage;
    }

    public virtual string GetDetails()
    {
        return $"Brand: {_brand}, Model: {_model}, Year: {_year}, Mileage: {_mileage}, Fuel Type: {_fuelType}";
    }


    public string Brand => _brand;
    public string Model => _model;
    public int Year => _year;
    public double Mileage => _mileage;
    public string FuelType => _fuelType;
}