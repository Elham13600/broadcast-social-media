namespace joehe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett tal: ");
            string input = Console.ReadLine();
            int myNumber = int.Parse(input);

            int result = Tenfold(myNumber);
            Console.WriteLine(result);

            result = Addfive(myNumber);
            Console.WriteLine(result);
        }

        static int Tenfold(int input)
        {
            int tenfoldNumber = input * 10;
            return tenfoldNumber;
        }

        static int Addfive(int input)
        {
            int addfiveNumber = input + 5;
            return addfiveNumber;
        }
    }

}
