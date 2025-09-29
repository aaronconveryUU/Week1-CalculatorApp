// See https://aka.ms/new-console-template for more information

int firstnumber = 5;

int secondnumber = 20;

int result = firstnumber + secondnumber;

Console.WriteLine($"The addition of both numbers is {result}");
Console.ReadKey();

Console.WriteLine("Type in the first number followed by the enter key");
firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the enter key");
secondnumber = Convert.ToInt32(Console.ReadLine());

result = firstnumber + secondnumber;
Console.WriteLine($"Adding {firstnumber} and {secondnumber} gives the answer {result}");
Console.ReadKey();
