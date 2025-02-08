
  abstract class Smart{
    protected string name="";
    protected int total_energy_usage;
    public int Total_energy_usage{
        get{return total_energy_usage;}
        set{total_energy_usage=value;}
    }
    protected string owner;
    public string Owner{
        get{return owner;}
        set{owner=value;}
    }
    protected string address;
    public string Address{
        get{return address;}
        set{address=value;}
    }


//-----------------------

    protected List<Device> allDevice=new List<Device>();    
    public void add(Device n){
        allDevice.Add(n);
    }
    
    protected Security sensors = new Security(false, 0, "unknown", false);

    public Security Sensors{
        set{sensors=value;}
    }
    protected Light lights = new Light(false, 0, "unknown", "red",0);
    public Light Lights {
        set{lights =value;}
    }
    protected Solarpanel solar=new Solarpanel(false, 0, "unknown", 0,0);
    public Solarpanel Solar{
        set{solar=value;}
    }














    
    public Smart(int total_energy_usage,string owner,string address){
        this.total_energy_usage=total_energy_usage;
        this.owner=owner;
        this.address=address;
        
        

    }


    public virtual void Ispis(){
        Console.WriteLine($"   Izvjestaj od Device sistema :");
        foreach(var i in allDevice){
            i.Ispis();  
        }
        
    }

    public virtual void allSmartDevice(){
    foreach(var i in allDevice){
        i.Ispis();
            }
    }

}

class Garage:Smart{

    private bool door_status;
    public bool Door_status{
        get { return door_status; }
        set { door_status = value; }
    }

    private int vehicle_capacity;
    public int Vehicle_capacity{
      get { return vehicle_capacity; }
      set{
        if (value >= 0){
            vehicle_capacity = value;
        }
        
    }
}

    private int current_vehicals;
    public int Current_vehicals{
    get { return current_vehicals; }
    set{
        if (value >= 0 && value <= vehicle_capacity) 
        {current_vehicals = value;}
       
    }
}





    public Garage(int total_energy_usage,string owner,string address,bool door_status,
    int vehicle_capacity,int current_vehicals):base(total_energy_usage,owner,address){
        this.name="Garaža";
        this.door_status=door_status;
        this.vehicle_capacity=vehicle_capacity;
        this.current_vehicals=current_vehicals;
    }

     public override void Ispis(){
        Console.WriteLine($"Naziv  Objekta je  {name},a njen vlasnik je {owner},nalazi se na adresi {address},i ovaj objekat trosi {total_energy_usage} W/h ");
        Console.WriteLine($"Vrata su trenutno otvorena: {door_status} ,u garazu moze da stane {vehicle_capacity} vozila,i u njoj je trrenutno { current_vehicals} vozila");
        base.Ispis();
    }
}

class House:Smart{


    private int number_of_rooms;
    public int NumberOfRooms{
    get { return number_of_rooms; }
    set { 
        if (value >= 0) {
            number_of_rooms = value;
        }      
    }
}

private int current_temperature;
public int CurrentTemperature
{
    get { return current_temperature; }
    set 
    { 
        if (value >= 0 && value <= 40) 
        {
            current_temperature = value;
        }
        else
        {
            current_temperature = 22; 
        }
    }
}




    public House(int total_energy_usage,string owner,string address,int number_of_rooms,
    int current_temperature):base(total_energy_usage,owner,address){
        this.name="Kuca";
        this.number_of_rooms=number_of_rooms;
        this.current_temperature=current_temperature;

    }


    public override void Ispis(){
     Console.WriteLine($"Naziv  Objekta je  {name},a njen vlasnik je {owner},nalazi se na adresi {address},i ovaj objekat trosi {total_energy_usage} W/h ");
     Console.WriteLine($"u Kuci ima {number_of_rooms} sobe, i u njima je temperatura  {current_temperature} ");
     base.Ispis();
    }

}

class Building:Smart{
    private int number_of_floors;
    public int NumberOfFloors{
        get { return number_of_floors; }
        set { 
            if (value>0){
            number_of_floors = value; } 
        }
    }

    private int total_apartment;
    public int TotalApartment{
        get { return total_apartment; }
        set { 
            if (value>0){
            number_of_floors = value; } 
        }
       
    }




    public Building(int total_energy_usage,string owner,string address,int number_of_floors,
    int total_apartment):base(total_energy_usage,owner,address){
        this.name="Zgrada ";
        this.number_of_floors=number_of_floors;
        this.total_apartment=total_apartment;
        }

    public override void Ispis(){
        Console.WriteLine($"Naziv  Objekta je  {name},a njen vlasnik je {owner},nalazi se na adresi {address},i ovaj objekat trosi {total_energy_usage} W/h ");
        Console.WriteLine($" i u njen broj stanova je  {total_apartment}  ");
        base.Ispis();
 }


}