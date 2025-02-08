

public static class SmartFactory{
     static List<Smart> allSmart=new List<Smart>();
   
    static public void Ispis(){
        foreach (var i in allSmart){
           i.Ispis();
        Console.WriteLine("----------");
        }
    }
   
    

public static void Make_Garage(){
        Console.WriteLine("How much energy use this Garage? ");
        int energy_use = int.Parse(Console.ReadLine() ?? "false");

        Console.WriteLine("Who is owner od Garage? ");
        string owner =(Console.ReadLine() ?? "unknow");

        Console.WriteLine("What is addres? ");
        string addres =  (Console.ReadLine() ?? "unknow");

        Console.WriteLine("For open door type true,for close type false");
        bool doorstatus= bool.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("what is vehical capacity of garage?");
        int vehicle_capacity= int.Parse(Console.ReadLine() ?? "0");

         Console.WriteLine("what is current capacity of garage?");
        int current= int.Parse(Console.ReadLine() ?? "0");


        Garage made_one=new Garage(energy_use,owner,addres,doorstatus,vehicle_capacity,current);

        Console.WriteLine("Do you want to upgrade you Garage with smart devise(Light,Security,solar panel)");
        bool on= bool.Parse(Console.ReadLine() ?? "0");
        while(on){
            made_one.add(DeviceFactory.MakeDevice() );
            Console.WriteLine("Do you want AGAIN to upgrade you Garage with smart devise(Light,Security,solar panel)");
            on= bool.Parse(Console.ReadLine() ?? "0");

        }
    
        
        
        allSmart.Add(made_one);
}




public static void Make_House(){
        Console.WriteLine("How much energy use this Garage? ");
        int energy_use =int.Parse(Console.ReadLine() ?? "false");

        Console.WriteLine("Who is owner od Garage? ");
        string owner =(Console.ReadLine() ?? "unknow");

        Console.WriteLine("What is addres? ");
        string addres = Console.ReadLine() ?? "unknow";


        Console.WriteLine("what is  number of rooms?");
        int number_of_rooms= int.Parse(Console.ReadLine() ?? "0");

         Console.WriteLine("what is current temperature of house?");
        int current= int.Parse(Console.ReadLine() ?? "0");


        House made_one=new House(energy_use,owner,addres,number_of_rooms,current);


        Console.WriteLine("Do you want to upgrade you House with smart devise(Light,Security,solar panel)");
        bool on= bool.Parse(Console.ReadLine() ?? "0");
        while(on){
            made_one.add(DeviceFactory.MakeDevice() );
            Console.WriteLine("Do you want AGAIN to upgrade you House with smart devise(Light,Security,solar panel)");
            on= bool.Parse(Console.ReadLine() ?? "0");
        }       
        
        allSmart.Add(made_one);
}




public static void Make_Building(){
        Console.WriteLine("How much energy use this Garage? ");
        int energy_use = int.Parse(Console.ReadLine() ?? "false");

        Console.WriteLine("Who is owner od Garage? ");
        string owner =(Console.ReadLine() ?? "unknow");

        Console.WriteLine("What is addres? ");
        string addres =  (Console.ReadLine() ?? "unknow");


        Console.WriteLine("what is  number of floors?");
        int number_of_floors= int.Parse(Console.ReadLine() ?? "0");

         Console.WriteLine("How much is appartmant in Building?");
        int total_apartment= int.Parse(Console.ReadLine() ?? "0");


        House made_one=new House(energy_use,owner,addres,number_of_floors,total_apartment);


        Console.WriteLine("Do you want to upgrade you Building with smart devise(Light,Security,solar panel)");
        bool on= bool.Parse(Console.ReadLine() ?? "0");
        while(on){
            made_one.add(DeviceFactory.MakeDevice() );
            Console.WriteLine("Do you want AGAIN to upgrade you Building with smart devise(Light,Security,solar panel)");
            on= bool.Parse(Console.ReadLine() ?? "0");
        }       
        
        allSmart.Add(made_one);
}




 public static void MakeSmart(){

     bool on = true;
     while (on){
         Console.WriteLine("Which smart object do you want to make?");
         Console.WriteLine("1.House");
         Console.WriteLine("2.Garage");
         Console.WriteLine("3.Building");
         int input = int.Parse(Console.ReadLine() ?? "0");
         switch (input){
         case 1:
            Make_House();
            break;
         case 2:
           Make_Garage();
            break;
         case 3:
           Make_Building();
            break;
         default:
           Console.WriteLine("Unos nije validan! Unesite broj od 1 do 3.");
            break;
         }
         
         
         Console.WriteLine("Do you want to make now smart object?");
         on = bool.Parse(Console.ReadLine() ?? "false");
         
     }
 }



}
