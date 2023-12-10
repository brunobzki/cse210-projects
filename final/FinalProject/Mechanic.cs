class Mechanic
{
    public string Name { get; private set; }
    public string Specialty { get; private set; }
    public List<Mechanic> MechanicsList { get; private set; }
    
    
    public Mechanic(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
        MechanicsList = new List<Mechanic>();
    }

    public Mechanic CreateNewMechanic()
    {
        Console.Write("Enter mechanic's name: ");
        string name = Console.ReadLine();
        Console.Write("Enter mechanic's specialty: ");
        string specialty = Console.ReadLine();
        Console.WriteLine("Mechanic correctly created\n");
        Console.WriteLine("Press Enter to go back to the menu.");
        Console.ReadLine();

        Mechanic newMechanic = new Mechanic(name, specialty);
        return newMechanic;
    }

    public void AddMechanicToList(Mechanic mechanic)
    {
        MechanicsList.Add(mechanic);
    }

    public void AssignTask()
    {

        Console.WriteLine($"Assigned task to mechanic {Name.ToUpper()}: ");
        Console.WriteLine();
        Console.WriteLine("Press Enter to go back to the menu.");
        Console.ReadLine();
    }

}