namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hej");


                Console.Write("Skriv ett tal");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                for (int i = 0; i < number; i++) ;

                Console.WriteLine(i + 1);
            }
        }
    }
}
