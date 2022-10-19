using System;

 namespace Uppgift_4._23
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett heltal");
            Console.WriteLine("skriv ordet slut när du är klar");
            string användarensOrd= Console.ReadLine();
             
            while (användarensOrd!="slut")
            {
                Console.WriteLine($"du skrev in helta {användarensOrd}");
                Console.WriteLine("skriv in ett heltal till");
                Console.WriteLine("skriv order slut för att avsluta");
                användarensOrd = Console.ReadLine();
                
            }
            Console.WriteLine("du skrev ordet slut, programmet kommer att avslutas ");

        }

    }
}
    