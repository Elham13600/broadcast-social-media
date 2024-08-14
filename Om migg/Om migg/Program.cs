using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Om_migg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej jag heter kevin och jag lär mig c# och detta är min första program");
            string name = "Kevin";
            Console.WriteLine(name);

            string color = "red";
            Console.WriteLine(color);
            
            Console.Write("Skriv namn: ");
            name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Är ett vakert namn");
            
            Console.Write("skriv favorite färg: ");
            color = Console.ReadLine();
            Console.WriteLine("fantastisk om färgen är");
            Console.WriteLine(color);

            

            Console.Write("Skriv in ditt födelseår: ");
            string input = Console.ReadLine();
            int birthyear = int.Parse(input);

            int age = 2024 - birthyear;
            Console.WriteLine("Du är ung och du är");
                Console.WriteLine(age);
            Console.WriteLine("år");

            if (age >= 60) ;

            Console.WriteLine("du är ung: ");
            Console.WriteLine("du är stark och modig");
            Console.WriteLine("Du är jätte bra");
            {
          
            }













        }
    }
}
