

class Program
{
    static void Main()
    {  
        

     
         Security Glavni=new Security(true,23,"hendek",true);
         Security Glavni2=new Security(true,33,"Donjici",true);

         Light Svjetlo=new Light(true,15,"hendek","plavo",25);
         Light Svjetlo2=new Light(true,85,"Donjici","crveno",35);
         Solarpanel Krov=new Solarpanel(true,23,"hendek",25,90);
         Solarpanel Krov2=new Solarpanel(true,33,"Donjici",20,80);



        Garage ispred_kuce=new Garage(25,"adis","hendek",true,5,5,Glavni,Svjetlo,Krov);
        //House Moja=new House(25,"adis","hendek",3,26,Glavni,Svjetlo,Krov);
        //Building Miljacka=new Building(25,"adis","Safet Zajko",3,26,Glavni,Svjetlo,Krov);

        //ispred_kuce.Senzori=Glavni2;ispred_kuce.Svjetla=Svjetlo2;ispred_kuce.Solar=Krov2; //odkomentarisite i  sa ovom linijomm koda u garazi sam promjenio senzore i svjetla i solarnipanel 
        
        ispred_kuce.add(Glavni2);
        ispred_kuce.add(Svjetlo2);
        ispred_kuce.add(Krov2);
       
       
       // ispred_kuce.allSmartDevice();

        List<Smart> allSmart=new List<Smart>();
        allSmart.Add(ispred_kuce);
        //allSmart.Add(Moja);
        //allSmart.Add(Miljacka);
        // 
        foreach (var i in allSmart){
            i.Ispis();
            Console.WriteLine("-----------------");
        }




    }
}
