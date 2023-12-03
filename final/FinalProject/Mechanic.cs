class Mechanic
{
    private string Name { get;  set; }
    private string Specialty { get;  set; }
    public List<DateTime> Schedule { get; private set; }

    public Mechanic(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
        Schedule = new List<DateTime>();
    }

    public void AssignTask(MaintenanceRecord maintenanceRecord)
    {

    }

    public void LogAvailability(DateTime date)
    {

    }
}