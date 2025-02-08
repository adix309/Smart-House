
//stavi ogranicenja na jacinu svjetlosti i tako jos ako negdje ima 


 public abstract class Device{
    protected  string name="";  
    protected bool status;
    public bool Status{
    get{return status;}
    set{status=value;}
    }
    protected double power_consumption;
    public  double Power_consumption{
    get{return power_consumption;}
    set{power_consumption=value;}
    }
    protected string location;
    public  string Location{
    get{return location;}
    set{location=value;}
    }
    public Device(bool status,double power_consumption,string location){
            this.status=status;        
            this.power_consumption=power_consumption;
            this.location=location;                             
          }
    public virtual  void Ispis(){
        Console.Write($"Ime uređaja je  {name},on trosi {power_consumption} W/h i njegova lokacija je {location},");      
       if(status){
        Console.WriteLine("I trenutno je ukljucen");
       }else{
        Console.WriteLine("I trenutno je iskljucen");
       }
    }
    


}

class Light:Device{

    private string color;
    public string Color{
        get{return color;}
        set{color=value;}
    }
    private int brightness;
    public int Brightness{
        get{return brightness;}
        set{
            if(value>0 && value<=100){
                brightness=value;
            }
        }
    }


    public Light(bool status, double power_consumption, string location, string color, int brightness)
    : base(status, power_consumption, location) {
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
    public int Effciency{
        get{return effciency;}      
        set{
               if(value>0 && value<100){
                    effciency=value;
                }  
            }
    }
    private  int angle;
    public int Angle{
        get{return angle;}
        set{
            if(value>0 && value < 360){
                angle=value;}
            }
    }

    public Solarpanel(bool status,double power_consumption,string location,int effciency,int angle)
                : base(status, power_consumption, location) {
            this.name = "Solarni panel";
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
    public bool Motion_detected{
        get{return motion_detected;}
        set{motion_detected=value;}
    }
    public Security(bool status,double power_consumption,string location,bool motion_detected)
            : base(status, power_consumption, location) {
        this.name = "Detektor pokreta";
        this.motion_detected=motion_detected;    
    }

    public override void Ispis(){
      base.Ispis();
      if(motion_detected){
        Console.WriteLine($"Uređaja je primjetio kretanje.");
      }else{
        Console.WriteLine($"Uređaja je nije primjetio kretanje.");
      }
     
     
    }    

}

