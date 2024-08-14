namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal: ");
            string input = Console.ReadLine();
            int firstNumber = int.Parse(input);

            Console.Write("Skriv ett till tal: ");
            input = Console.ReadLine();
            int secondNumber = int.Parse(input);

            Console.Write("Skriv sub eller add: ");
            string op = Console.ReadLine();

           int myResult = Calculate(firstNumber, secondNumber, op);
            Console.WriteLine(myResult);
        }

        static int Calculate(int n1, int n2, string op)
        {
            int result = 0;

            if (op == "add")
            {
                result = n1 + n2;
            }
            else if(op == "sub")
            {
                result = n1 - n2;
            }

            return result;
        }
    }
}
