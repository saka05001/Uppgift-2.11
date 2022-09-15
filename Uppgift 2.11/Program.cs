using System;
    
 namespace Uppgift_2._11

 {
    class program
    {
     static void Main(string[] args)
     {
        Console.WriteLine("Hur långt hoppade Elin?");
        string x = Console.ReadLine();   
            
        Console.WriteLine("Hur långt hoppade Alma?");
        string a = Console.ReadLine();


        int y = int.Parse(a);
        Console.WriteLine("Elin hoppade  "+ x );
     }


    }
 }