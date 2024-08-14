namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int speed = 0;
            for (int i = 0; i < 10; i++)
            {
                speed++;
            }

            Console.WriteLine(speed);

            speed += 10;

            Console.WriteLine(speed);
        }
    }
}
