class Reminder
{
    private string _reminderType;
    private DateTime _date;
    private double _mileage;

    public void GenerateReminder(Vehicle vehicle)
    {

        Console.WriteLine($"Reminder generated for {vehicle.Brand} {vehicle.Model}.");
    }

    public void ScheduleReminder(Vehicle vehicle)
    {
        Console.WriteLine($"Reminder scheduled for {vehicle.Brand} {vehicle.Model}.");
    }
}