
public static class DeviceFactory
{
    public static Device Make_light(){
        Console.WriteLine("true for on, false for off ");
        bool status = bool.Parse(Console.ReadLine() ?? "false");

        Console.WriteLine("How much energy spend we expect?");
        double power_consumption = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Where to install?");
        string location = Console.ReadLine() ?? "unknown";

        Console.WriteLine("Which color you want?");
        string color = Console.ReadLine() ?? "white";

        Console.WriteLine("How much brightness?");
        int brightness = int.TryParse(Console.ReadLine(), out var bright) ? bright : 0;

        return new Light(status, power_consumption, location, color, brightness);
    }


      
  public static Device Make_solar(){
          Console.WriteLine("true for on ,false for off ");
          bool status = bool.Parse(Console.ReadLine() ?? "false");
          Console.WriteLine("How much energy spend we expect?");
          double power_consumption= double.Parse(Console.ReadLine() ?? "0");
          Console.WriteLine("Where to install?");
          string location = Console.ReadLine() ?? "unknow";
          Console.WriteLine("what is efficiency od device?");
          int  efficiency = int.Parse(Console.ReadLine() ?? "0");
          Console.WriteLine("How much angle?");
          int angle=int.Parse(Console.ReadLine() ?? "0");
          
          return new Solarpanel(status,power_consumption,location,efficiency,angle);
          
          
  }
  
  public static Device Make_Sec(){
          Console.WriteLine("true for on sistem ,false for off sistem ");
          bool status = bool.Parse(Console.ReadLine() ?? "false");
          Console.WriteLine("How much energy spend we expect?");
          double power_consumption= double.Parse(Console.ReadLine() ?? "0");
          Console.WriteLine("Where to install?");
          string location = Console.ReadLine() ?? "unknow";
          
          Console.WriteLine("true for motion detected ,false for not ");
          bool mot = bool.Parse(Console.ReadLine() ?? "false");
          
      
          Console.WriteLine($"NAPRAVIO security");
          return new Security(status,power_consumption,location,mot);
          
          
          
  }
  public static Device MakeDevice(){
      bool on = true;
      Device? Selectdevice=null;
      while(Selectdevice == null){
              while (on){
                 Console.WriteLine("Whic Device you want to intsall?");
                 Console.WriteLine("1.Light");
                 Console.WriteLine("2.solar panel");
                 Console.WriteLine("3.Security");
                 int input = int.Parse(Console.ReadLine() ?? "0");
                 switch (input){
                 case 1:
                     Selectdevice= Make_light();
                     on=false;
                     break;
                 case 2:
                     Selectdevice= Make_solar();
                      on=false;
                      break;
                 case 3:
                     Selectdevice=Make_Sec();
                     on=false;
                     break;
                 default:
                   Console.WriteLine("Unos nije validan! Unesite broj od 1 do 3.");
                    break;
                  }            
          
              }
      }
      
      return Selectdevice;
  }

}
