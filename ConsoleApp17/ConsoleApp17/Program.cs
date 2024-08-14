using System.Reflection;
using System.Security.Principal;
using ConsoleApp17;

Book book = new Book();
{
    string Title = "Harry P";
    int Pages = 123;
};

Console.WriteLine(book);

Car myVolvo = new Car("Volvo", "740");
Car mySaab = new Car("Saab", "9000");

Console.WriteLine(myVolvo);
Console.WriteLine(mySaab);

Customer myCustomer = new Customer()
{
    Username = "Anna",
    Password = "123",
    BonusPoints = 1000
};

Admin admin = new Admin()
{
    Username = "Kevin",
    Password = "123",
    Role = "Admin",
};