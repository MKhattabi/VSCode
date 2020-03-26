using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            string message = $"Hello {place}";
        //    Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console");
            Console.WriteLine(message);
        //    Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");

            int numRings =3;
if (numRings >= 5)
{
    Console.WriteLine("You are welcome to join the party");
}
else if (numRings > 2)
{
    Console.WriteLine($"Decent...but {numRings} rings aren't enough");
}
else
{
    Console.WriteLine("Go win some more rings");
}

        }
    }
}  
