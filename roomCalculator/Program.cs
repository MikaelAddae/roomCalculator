Console.WriteLine("Hello. Welcome to the room size calculator");
Console.WriteLine("Please enter the length of the room");
string length = Console.ReadLine();
double l = double.Parse(length);

Console.WriteLine("Please enter the width of the room");
string width = Console.ReadLine();
double w = double.Parse(width);

Console.WriteLine("Please enter the height of the room");
string height = Console.ReadLine();
double h = double.Parse(height);

double area = l * w;
double perimeter = 2 * (l + w);
double volume = l * w * h;
double surfaceArea = (2 * l * w) + (2 * l * h) + (2 * h * w);

Console.WriteLine($"The area of that room is {area}");
Console.WriteLine($"The perimeter of that room is {perimeter}");
Console.WriteLine($"The volume of the room is {volume}");
Console.WriteLine($"The surface area of the room is {surfaceArea}");

if (area <= 250)
{
    Console.WriteLine("That is a small room");
}
else if (area <= 650)
{
    Console.WriteLine("That is a medium room");
}
else
{
    Console.WriteLine("That is a large room");
}


Console.WriteLine("Thank you for using the room size calculator!");