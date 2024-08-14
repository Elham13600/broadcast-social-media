using System.ComponentModel.Design;
using System.Net.NetworkInformation;

namespace project_1_again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ditt namn: ");
            string name = Console.ReadLine();

            if (name == "Bardia")

                Console.WriteLine("Vi har samma namn");

            else if(name == "Anna") ;

            Console.WriteLine();

            else

                Console.WriteLine("Du har ett vackert namn");

            Console.WriteLine("Klar");

        }
    }
}
