

public static class SmartFactory
{
    static List<Smart> allSmart = new List<Smart>();
    static public void IspisSvega()
    {
        foreach (var i in allSmart)
        {
            i.ispisSmartObjekta();
            Console.WriteLine("---");
        }
    }

    static void UpgradeObject(Smart made_one)
    {
        Console.WriteLine("Do you want to upgrade you Garage with smart devise(Light,Security,solar panel)?For yes type 'true',for no type 'false'");
        bool on = bool.TryParse(Console.ReadLine(), out var onn) ? onn : false;
        while (on)
        {
            made_one.add(DeviceFactory.MakeDevice());
            Console.WriteLine("Do you want AGAIN to upgrade you Garage with smart devise(Light,Security,solar panel)For yes type 'true',for no type 'false' ");
            on = bool.TryParse(Console.ReadLine(), out var oon) ? oon : false;
        }
    }



    public static void Make_Garage(int energy_use, string owner, string addres)
    {
        Console.WriteLine("For open door type 'true',for close type 'false' ");
        bool doorstatus = bool.TryParse(Console.ReadLine(), out var door) ? door : false;

        Console.WriteLine("What is vehical capacity of garage?");
        int vehicle_capacity = int.TryParse(Console.ReadLine(), out var cap) ? cap : 0;

        Console.WriteLine("How many vehicles are currently in the garage?");
        int current = int.TryParse(Console.ReadLine(), out var curr) ? curr : 0;

        Garage made_one = new Garage(energy_use, owner, addres, doorstatus, vehicle_capacity, current);

        UpgradeObject(made_one);

        allSmart.Add(made_one);
    }




    public static void Make_House(int energy_use, string owner, string addres)
    {
        Console.WriteLine("What is  number of rooms?");
        int number_of_rooms = int.TryParse(Console.ReadLine(), out var room) ? room : 0;

        Console.WriteLine("What is current temperature of house?");
        int current = int.TryParse(Console.ReadLine(), out var curr) ? curr : 0;

        House made_one = new House(energy_use, owner, addres, number_of_rooms, current);

        UpgradeObject(made_one);

        allSmart.Add(made_one);
    }




    public static void Make_Building(int energy_use, string owner, string addres)
    {
        Console.WriteLine("How many floors does the building have?");
        int number_of_floors = int.TryParse(Console.ReadLine(), out var number) ? number : 0;

        Console.WriteLine("How much is appartmant in Building?");
        int total_apartment = int.TryParse(Console.ReadLine(), out var total) ? total : 0;

        Building made_one = new Building(energy_use, owner, addres, number_of_floors, total_apartment);

        UpgradeObject(made_one);

        allSmart.Add(made_one);
    }




    public static void MakeSmart()
    {
        bool on = true;
        while (on)
        {
            Console.WriteLine("Which smart object do you want to make?");
            Console.WriteLine("1.House");
            Console.WriteLine("2.Garage");
            Console.WriteLine("3.Building");
            int input = int.Parse(Console.ReadLine() ?? "0");


            Console.WriteLine("How much energy use this Object? ");
            int energy_use = int.TryParse(Console.ReadLine(), out var eng) ? eng : 0;
            Console.WriteLine("Who is owner od Object? ");
            string owner = Console.ReadLine() ?? "unknow";
            Console.WriteLine("What is addres? ");
            string addres = Console.ReadLine() ?? "unknow";


            switch (input)
            {
                case 1:
                    Make_House(energy_use, owner, addres);
                    break;
                case 2:
                    Make_Garage(energy_use, owner, addres);
                    break;
                case 3:
                    Make_Building(energy_use, owner, addres);
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 3.");
                    break;
            }


            Console.WriteLine("Do you want to make now smart object?For yes type 'true',for no type 'false' ");
            on = bool.TryParse(Console.ReadLine(), out var oon) ? oon : false;
        }
    }



}
