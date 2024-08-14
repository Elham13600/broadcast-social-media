namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Lamborghini";
            myCar.Model = "V12 hybrid coupe";

            Console.WriteLine("Din bil är av märket: " + myCar.Make);

            Car otherCar =  new Car();
            otherCar.Make = "bugati";
            otherCar.Model = "Top g";

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(otherCar.Make);
            Console.WriteLine(otherCar.Model);
        }
    }
}
