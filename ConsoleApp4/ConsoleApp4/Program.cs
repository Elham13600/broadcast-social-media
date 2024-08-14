namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++) { }

            int dice = rnd.Next(1, 7);  // creates a number beetwen 1 and 6
            Console.WriteLine(dice);
        }
    }
}
