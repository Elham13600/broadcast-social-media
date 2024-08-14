using System.ComponentModel.Design;

namespace project_1_for_the_2nd_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv din ålder: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine(age);

            if (age >= 18)

                Console.WriteLine("Du får ta körkort");

            else if (age >= 16) ;

            Console.WriteLine("Du får övningsköra");
        }
            

    }     
               
        
    
}
