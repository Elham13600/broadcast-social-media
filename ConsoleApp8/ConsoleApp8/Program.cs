namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car  myCar = new Car();
            myCar.Speed = 100;

            myCar.IncreaseSpeed();

            Console.WriteLine("Bilen kör i! " + myCar.Speed);

            Car otherCar = new Car();
            otherCar.Speed = 50;
            Console.WriteLine("Andra bilen kör i " + otherCar.Speed);
            otherCar.IncreaseSpeed();
            Console.WriteLine("Andra bilen kör i " + otherCar.Speed);

            myCar.IncreaseSpeed();
            Console.WriteLine("Bilen kör i! " + myCar.Speed);

        }
    }
}
