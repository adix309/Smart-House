
public static class DeviceFactory
{
    public static Device Make_light(bool status, double power_consumption, string location)
    {

        Console.WriteLine("Which color you want?");
        string color = Console.ReadLine() ?? "unknow";

        Console.WriteLine("How much brightness?");
        int brightness = int.TryParse(Console.ReadLine(), out var bright) ? bright : 0;

        return new Light(status, power_consumption, location, color, brightness);
    }



    public static Device Make_solar(bool status, double power_consumption, string location)
    {
        Console.WriteLine("what is efficiency od device?");
        int efficiency = int.TryParse(Console.ReadLine(), out var eff) ? eff : 0;
        Console.WriteLine("How much angle?");
        int angle = int.TryParse(Console.ReadLine(), out var an) ? an : 0;

        return new Solarpanel(status, power_consumption, location, efficiency, angle);


    }

    public static Device Make_Sec(bool status, double power_consumption, string location)
    {
        Console.WriteLine("Type 'true' for motion detected ,and 'false' for not ");
        bool motion = bool.TryParse(Console.ReadLine(), out var mot) ? mot : false;

        return new Security(status, power_consumption, location, motion);
    }
    public static Device MakeDevice()
    {
        bool on = true;
        Device? Selectdevice = null;
        while (Selectdevice == null)
        {
            while (on)
            {
                Console.WriteLine("Whic Device you want to intsall?");
                Console.WriteLine("1.Light");
                Console.WriteLine("2.solar panel");
                Console.WriteLine("3.Security");
                int input = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("Type 'true' for on,and 'false' for off ");
                bool status = bool.TryParse(Console.ReadLine(), out var stat) ? stat : false;
                Console.WriteLine("How much energy spend we expect on this device?");
                double power_consumption = double.TryParse(Console.ReadLine(), out var pow) ? pow : 0;
                Console.WriteLine("Where to install this device?");
                string location = Console.ReadLine() ?? "unknow"; ;



                switch (input)
                {
                    case 1:
                        Selectdevice = Make_light(status, power_consumption, location);
                        on = false;
                        break;
                    case 2:
                        Selectdevice = Make_solar(status, power_consumption, location);
                        on = false;
                        break;
                    case 3:
                        Selectdevice = Make_Sec(status, power_consumption, location);
                        on = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please enter a number between 1 and 3.");
                        break;
                }

            }
        }

        return Selectdevice;
    }

}
