using System.ComponentModel.Design;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till mitt gissningspel");

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            Console.WriteLine("Vi har slumpat ett tal mellan 1-100");

            while (guess != randomNumber) { 
            {
                {
                    Console.Write("Gissa numret: ");
                    string input = Console.ReadLine();
                    int guess = int.Parse(input);

                    if (guess == randomNumber) ;
                     

                    Console.WriteLine("Du gissade rätt");


                        
                }
                    { 
            }
    }
}
