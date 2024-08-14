namespace jag_vet_inte_längre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input != "stopp") ;
            {
              
                Console.Write("skriv in ditt namn");
                input = Console.ReadLine();
                Console.WriteLine("Du skrev" + input);
            }
        }
    }
}
