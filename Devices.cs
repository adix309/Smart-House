
public abstract class Device
{
    protected string name = "";
    protected bool status;
    protected double power_consumption;
    protected string location;

    public Device(bool status, double power_consumption, string location)
    {
        this.status = status;
        this.power_consumption = power_consumption;
        this.location = location;
    }
    public virtual void PrintSingleDevice()
    {


        Console.Write($"The device name is {name}, it consumes {power_consumption} W/h, and its location is {location}, ");
        if (status)
        {
            Console.WriteLine("and it is currently turned on.");
        }
        else
        {
            Console.WriteLine("and it is currently turned off.");
        }







    }
}

class Light : Device
{
    private string color;

    private int brightness;
    public Light(bool status, double power_consumption, string location, string color, int brightness)
    : base(status, power_consumption, location)
    {
        this.name = "Light ";
        this.color = color;
        if (brightness > 100)
        {
            brightness = 100;
        }
        else if (brightness < 0)
        {
            brightness = 0;
        }

        this.brightness = brightness;
    }


    public override void PrintSingleDevice()
    {
        base.PrintSingleDevice();
        Console.WriteLine($"and color is {color} and  light intensity is {brightness} ");


    }
}
class Solarpanel : Device
{
    private int effciency;
    private int angle;

    public Solarpanel(bool status, double power_consumption, string location, int effciency, int angle)
                : base(status, power_consumption, location)
    {
        this.name = "Solar panel";
        this.effciency = effciency;
        this.angle = angle;
    }
    public override void PrintSingleDevice()
    {
        base.PrintSingleDevice();
        Console.WriteLine($"The angle of the device is {angle} degrees and its efficiency is {effciency} %");
    }
}
class Security : Device
{
    private bool motion_detected;
    public Security(bool status, double power_consumption, string location, bool motion_detected)
           : base(status, power_consumption, location)
    {
        this.name = "Motion detector";
        this.motion_detected = motion_detected;
    }

    public override void PrintSingleDevice()
    {
        base.PrintSingleDevice();
        if (motion_detected)
        {
            Console.WriteLine($"The device detected movement.");
        }
        else
        {
            Console.WriteLine($"The device did not detected movement.");
        }


    }

}

