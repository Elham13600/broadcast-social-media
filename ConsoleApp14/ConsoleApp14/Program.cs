// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hej världen");

Console.Write("Mata in din ålder: ");

string input = Console.ReadLine();

int age = 0;

try
{
    age = int.Parse(input);
}
catch
{
    Console.WriteLine("Fel på inmatad ålder");
}

age = age + 10;

Console.WriteLine("om tio år är du" + age);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Hej!");
}

int randomNumber = 0;

Random rnd = new Random();

randomNumber = rnd.Next(10);

while (randomNumber != 5)
{
    Console.WriteLine(randomNumber);
    randomNumber = rnd.Next(10);
}
