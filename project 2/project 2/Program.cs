using System.Threading.Channels;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ditt födelseår: ");
            string input = Console.ReadLine();
            int birthyear = int.Parse(input);

            int age = (2024 - birthyear);

            Console.WriteLine(age);
        }
    }
}
