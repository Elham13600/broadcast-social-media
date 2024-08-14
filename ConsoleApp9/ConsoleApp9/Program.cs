namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Car myCar = new Car(100);

            Console.WriteLine(myCar.Speed);

            Car yourCar = new Car(50);
            yourCar.IncreaseSpeed();
            Console.WriteLine(yourCar.Speed);

            yourCar.stop();
            Console.WriteLine(yourCar.Speed);
        }
    }
}
