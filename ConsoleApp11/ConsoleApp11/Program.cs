namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal: ");
            string input = Console.ReadLine();
            int myNumber = int.Parse(input);

            Console.WriteLine(myNumber);
        }
    }
}
