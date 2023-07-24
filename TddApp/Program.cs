// See https://aka.ms/new-console-template for more information
using TddApp;
var methodClass = new FizzBuzz();
Console.WriteLine($"Hello, {methodClass.CreateName("Mark", "Finta")}");

for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(methodClass.GenerateFizzBuzz(i));
}
