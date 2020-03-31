using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            string message = $"Hello {place}";
            //Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console");
            Console.WriteLine(message);
            //Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");


            // Conditions part....

            int num_Rings = 3;
            if (num_Rings >= 5)
            {
                Console.WriteLine("You are welcome to join the party");
            }
            else if (num_Rings > 2)
            {
                Console.WriteLine($"Decent...but {num_Rings} rings aren't enough");
            }
            else
            {
                Console.WriteLine("Go win some more rings");
            }

            // Comparison & Logical Operators
            int numRings = 5;
            string name = "Kobe";
            if (numRings >= 5 && name == "Kobe")
            {
                Console.WriteLine($"Welcome to the party {name}, congratulations on your {numRings} championships!");
            }

            //-----------------------------------------------------------
            int numRing = 5;
            int numOfAllStarAppearances = 17;
            if (numRing >= 5 || numOfAllStarAppearances > 3)
            {
                Console.WriteLine("Welcome, you are truly a legend");
            }

            //--------------------------------------------------------------
            bool crazy = true;
            if (!crazy)
            {
                Console.WriteLine("Let's party!");
            }

            // for Loops
            int start = 0;
            int end = 5;
            // loop from start to end including end
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            // loop from start to end excluding end
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("    ");

            // while loops
            int b = 1;
            while (b < 6)
            {
                Console.WriteLine(b);
                b = b + 1;
            }

            Console.WriteLine("    ");

            // random values

            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2, 8));
            }





        }
    }
}
