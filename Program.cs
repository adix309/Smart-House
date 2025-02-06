

 abstract class Device{
    protected  string name="";  
    protected bool status;
    protected double power_consumtion;
    protected string location;
    public Device(bool status,double power_consumtion,string location){
            this.status=status;        
            this.power_consumtion=power_consumtion;
            this.location=location;                             
          }
    public virtual  void Ispis(){
        Console.WriteLine($"Ime uređaja je  {name},on trosi {power_consumtion} W/h i nalazi se na adresi {location}");      
       
    }

}

class Light:Device{

    private string color;
    private int brightness;


    public Light(bool status, double power_consumtion, string location, string color, int brightness)
    : base(status, power_consumtion, location) {
    this.name = "Svjetlo ";
    this.color = color;
    this.brightness = brightness;
    }
    
    
    public override void Ispis(){
            base.Ispis();
            Console.WriteLine($"i njegova boja je {color} a jacina svjetla je {brightness} ");
    
    
    }    
}
class Solarpanel:Device{

    private  int effciency;
    private  int angle;

    public Solarpanel(bool status,double power_consumtion,string location,int effciency,int angle)
                : base(status, power_consumtion, location) {
            this.name = "Solarni panell";
            this.effciency=effciency;
            this.angle=angle;
    }
     public override void Ispis(){
         base.Ispis();
         Console.WriteLine($"Ugao uređaja je  {angle} a njegova efikasnost je {effciency} %");
        
    }    

}

class Security:Device{

    private bool motion_detected;
    public Security(bool status,double power_consumtion,string location,bool motion_detected)
            : base(status, power_consumtion, location) {
        this.name = "Detektor pokreta";
        this.motion_detected=motion_detected;    
    }

    public override void Ispis(){
      base.Ispis();
      Console.WriteLine($"Uređaja je primjetio kretanje : {motion_detected} ");
     
    }    

}


abstract class Smart{
    protected string name="";
    protected int total_energy_usage;
    protected string owner;
    protected string address;

//-----------------------
    protected Security senzori;
    protected Light svjetla;
    protected Solarpanel solar;


    public Smart(int total_energy_usage,string owner,string address,Security senzori,Light svjetla,Solarpanel solar){
        this.solar=solar;
        this.senzori=senzori;
        this.svjetla=svjetla;
        this.total_energy_usage=total_energy_usage;
        this.owner=owner;
        this.address=address;
    }

    public virtual void Ispis(){
        Console.WriteLine($"  Izvjestaj od bezbjednosog sistema :");senzori.Ispis();
        Console.WriteLine($"  Izvjestaj od Rasvjetnog sistema :");svjetla.Ispis();
        Console.WriteLine($"  Izvjestaj od Solarnog sistema :");solar.Ispis();
          
    }

}

class Garage:Smart{
    private bool door_status;
    private int vehicle_capacity;
    private int current_vehicals;



    

    public Garage(int total_energy_usage,string owner,string address,bool door_status,
    int vehicle_capacity,int current_vehicals,Security senzori,Light svjetla,Solarpanel solar):base(total_energy_usage,owner,address,senzori,svjetla,solar){
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
    private int current_temperature;

    public House(int total_energy_usage,string owner,string address,int number_of_rooms,
    int current_temperature,Security senzori,Light svjetla,Solarpanel solar):base(total_energy_usage,owner,address,senzori,svjetla,solar){
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
     private int total_apartment;

    public Building(int total_energy_usage,string owner,string address,int number_of_floors,
    int total_apartment,Security senzori,Light svjetla,Solarpanel solar):base(total_energy_usage,owner,address,senzori,svjetla,solar){
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


class Program
{
    static void Main()
    {  
        Console.WriteLine();
        Security Glavni=new Security(true,23,"hendek",true);
        Light Svjetlo=new Light(true,15,"hendek","plavo",25);
        Solarpanel Krov=new Solarpanel(true,23,"hendek",25,90);



        Garage ispred_kuce=new Garage(25,"adis","hendek",true,5,5,Glavni,Svjetlo,Krov);
        House Moja=new House(25,"adis","hendek",3,26,Glavni,Svjetlo,Krov);
        Building Miljacka=new Building(25,"adis","Safet Zajko",3,26,Glavni,Svjetlo,Krov);


        
        
        List<Smart> allSmart=new List<Smart>();
        allSmart.Add(ispred_kuce);
        allSmart.Add(Moja);
        allSmart.Add(Miljacka);

        

        foreach (var i in allSmart){
            i.Ispis();
            Console.WriteLine("-----------------");
        }

    }
}
