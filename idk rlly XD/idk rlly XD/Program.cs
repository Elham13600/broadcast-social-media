using System.ComponentModel.Design;
using System.Diagnostics;

namespace idk_rlly_XD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv din namn: ");
          string name = Console.ReadLine();

            Console.Write("Skriv din ålder: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (name == "Bardia" && age == 12) ;

            Console.WriteLine("Vi har samma namn och ålder");

            if (name == "Bardia" || age == 12) ;

            Console.WriteLine("Vi har samma namn eller ålder");

            if (age <= 16 || age >= 65) ;

            Console.WriteLine("Du går i skolan eller är i pensjonär");
        }
    }
}
