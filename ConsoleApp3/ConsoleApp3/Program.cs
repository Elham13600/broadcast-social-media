namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input != "stop") ;

            Console.WriteLine("Skriv ett ord");
            input = Console.ReadLine();
            Console.WriteLine("Du skrev" + input);
        }
    }
}
