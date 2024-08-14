// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hej världen");

int age = 12;

if (age < 30)
{
    Console.WriteLine("Du är yngre än 30");
}
else if (age > 30)
{
    Console.WriteLine("Du är äldre än 30");
}

string name = "Anna";

if (name == "Kevin")
{
    Console.WriteLine("Vi har samma namn");
}
else if(name == "Anna")
{
    Console.WriteLine("Du har samma namn som min syster");
}

double pi = 3.14;
double radius = 7;

Console.WriteLine("Arean av cirkeln är" + (radius * radius * pi));
Console.WriteLine("Omkretsen av cirkeln är" + (2 * radius * pi));

bool correct = false;

if (correct)
{
    Console.WriteLine("Det är korrect");
}

bool longName = (name.Length > 5);

if (longName)
{
    Console.WriteLine("Ditt namn har längre än 5 tecken");
}