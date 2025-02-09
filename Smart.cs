
abstract class Smart
{
    protected string name = "";
    protected int total_energy_usage;
    protected string owner;
    protected string address;

    protected List<Device> allDevice = new List<Device>();
    public void add(Device n)
    {
        allDevice.Add(n);
    }

    protected Security sensors = new Security(false, 0, "unknown", false);
    protected Light lights = new Light(false, 0, "unknown", "red", 0);
    protected Solarpanel solar = new Solarpanel(false, 0, "unknown", 0, 0);
    public Smart(int total_energy_usage, string owner, string address)
    {
        this.total_energy_usage = total_energy_usage;
        this.owner = owner;
        this.address = address;
    }


    public virtual void ispisSmartObjekta()
    {
        Console.WriteLine($"   Report from the Device system:");
        foreach (var i in allDevice)
        {
            i.PrintSingleDevice();
        }

    }

}

class Garage : Smart
{

    private bool door_status;

    private int vehicle_capacity;

    private int current_vehicles;

    public Garage(int total_energy_usage, string owner, string address, bool door_status,
    int vehicle_capacity, int current_vehicles) : base(total_energy_usage, owner, address)
    {
        this.name = "Garage";
        this.door_status = door_status;
        this.vehicle_capacity = vehicle_capacity;
        this.current_vehicles = current_vehicles;
    }

    public override void ispisSmartObjekta()
    {
        Console.WriteLine($"The name of the object is {name}, its owner is {owner}, it is located at {address}, and this object consumes {total_energy_usage} W/h.");
        Console.WriteLine($"The door is currently open: {door_status}, vehicle capacity is  {vehicle_capacity} , and it currently contains {current_vehicles} vehicles.");
        base.ispisSmartObjekta();
    }
}

class House : Smart
{


    private int number_of_rooms;

    private int current_temperature;
    public House(int total_energy_usage, string owner, string address, int number_of_rooms,
    int current_temperature) : base(total_energy_usage, owner, address)
    {
        this.name = "House";
        this.number_of_rooms = number_of_rooms;
        this.current_temperature = current_temperature;

    }


    public override void ispisSmartObjekta()
    {
        Console.WriteLine($"The name of the object is {name}, its owner is {owner}, it is located at {address}, and this object consumes {total_energy_usage} W/h.");
        Console.WriteLine($"The house has {number_of_rooms} rooms, and the current temperature in them is {current_temperature}.");
        base.ispisSmartObjekta();
    }

}

class Building : Smart
{
    private int number_of_floors;
    private int total_apartment;

    public Building(int total_energy_usage, string owner, string address, int number_of_floors,
    int total_apartment) : base(total_energy_usage, owner, address)
    {
        this.name = "Building ";
        this.number_of_floors = number_of_floors;
        this.total_apartment = total_apartment;
    }

    public override void ispisSmartObjekta()
    {
        Console.WriteLine($"The name of the object is {name}, its owner is {owner}, it is located at {address}, and this object consumes {total_energy_usage} W/h.");
        Console.WriteLine($"It has a total of {total_apartment} apartments, and there are {number_of_floors} floors.");
        base.ispisSmartObjekta();
    }


}