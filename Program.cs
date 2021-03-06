﻿using System;
using System.Collections.Generic;

namespace FirstCSharp {
    class Program {
        static void Main (string[] args) {
            string place = "Coding Dojo";
            string message = $"Hello {place}";
            //Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console");
            Console.WriteLine (message);
            //Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");

            // Conditions part....

            int num_Rings = 3;
            if (num_Rings >= 5) {
                Console.WriteLine ("You are welcome to join the party");
            } else if (num_Rings > 2) {
                Console.WriteLine ($"Decent...but {num_Rings} rings aren't enough");
            } else {
                Console.WriteLine ("Go win some more rings");
            }

            // Comparison & Logical Operators
            int numRings = 5;
            string name = "Kobe";
            if (numRings >= 5 && name == "Kobe") {
                Console.WriteLine ($"Welcome to the party {name}, congratulations on your {numRings} championships!");
            }
            //-----------------------------------------------------------
            int numRing = 5;
            int numOfAllStarAppearances = 17;
            if (numRing >= 5 || numOfAllStarAppearances > 3) {
                Console.WriteLine ("Welcome, you are truly a legend");
            }
            //--------------------------------------------------------------
            bool crazy = true;
            if (!crazy) {
                Console.WriteLine ("Let's party!");
            }

            // for Loops
            int start = 0;
            int end = 5;
            // loop from start to end including end
            for (int i = start; i <= end; i++) {
                Console.WriteLine (i);
            }
            // loop from start to end excluding end
            for (int i = start; i < end; i++) {
                Console.WriteLine (i);
            }
            Console.WriteLine ("    ");
            // while loops
            int b = 1;
            while (b < 6) {
                Console.WriteLine (b);
                b = b + 1;
            }
            Console.WriteLine ("    ");

            // random values
            Random rand = new Random ();
            for (int val = 0; val < 10; val++) {
                //Prints the next random value between 2 and 8
                Console.WriteLine (rand.Next (2, 8));
            }
            // // print from 1 to 255
            // for (int FirstQ = 1; FirstQ < 256; FirstQ++) {
            //     Console.WriteLine (FirstQ);
            // }
            // Console.WriteLine (" ");
            // // print number from 1 to 100 that are divisible by 3 or 5, but not both
            // for (int SecondQ = 1; SecondQ < 101; SecondQ++) {
            //     if (SecondQ % 3 == 0 || SecondQ % 5 == 0) {
            //         Console.WriteLine (SecondQ);
            //     }
            // }
            // Console.WriteLine ("");

            // // Practice 3 
            // for (int ThirdQ = 1; ThirdQ < 101; ThirdQ++) {
            //     if (ThirdQ % 3 == 0 && ThirdQ % 5 == 0) {
            //         Console.WriteLine (ThirdQ + " FizzBuzz");
            //     } else if (ThirdQ % 3 == 0) {
            //         Console.WriteLine (ThirdQ + " Fizz");
            //     } else if (ThirdQ % 5 == 0) {
            //         Console.WriteLine (ThirdQ + " Buzz");
            //     }
            // }
            Console.WriteLine (" ");

            // Arrays
            int[] numArray1;
            numArray1 = new int[] { 5, 4, 8 };
            Console.WriteLine (numArray1[1]);

            // Accessing Arrays
            int[] arr1 = { 1, 2, 3, 4 };
            Console.WriteLine ($"The first number of the arr is {arr1[0]}");
            arr1[0] = 8;
            Console.WriteLine ($"The first number of the arr is now {arr1[0]}");
            // The array has now changed!   
            Console.WriteLine (" ");

            // // Iterating through an array
            // string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx" };
            // // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            // for (int idx = 0; idx < myCars.Length; idx++) {
            //     Console.WriteLine ($"I own a {myCars[idx]}");
            // }
            // Console.WriteLine (" ");

            string[] myCars1 = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx" };
            foreach (string car in myCars1) {
                // We no longer need the index, because variable 'car' already represents each indexed value
                Console.WriteLine ($"I own a {car}");
            }
            Console.WriteLine (" ");
            //------------------------------------------------------------------------------------------------------------

            // Lists
            List<string> List1 = new List<string> ();
            List1.Add ("Mohammed");
            List1.Add ("Ahmed");
            List1.Add ("Ali");
            List1.Add ("Mikel");
            List1.Add ("Marcelo");
            Console.WriteLine (List1[3]);
            Console.WriteLine ($"We currently know {List1.Count} Names.");
            Console.WriteLine (" ");

            //we can easily loop through the list of them with a C-style for loop
            //this time, however, Count is the attribute for a number of items.
            Console.WriteLine ("The current manufacturers we have seen are:");
            for (var idx = 0; idx < List1.Count; idx++) {
                Console.WriteLine ("-" + List1[idx]);
            }

            // Insert a new item between a specific index
            List1.Insert (1, "Suzan");

            //Removal from Generic List
            List1.Remove ("Ali");
            List1.RemoveAt (0);

            //The updated list can then be iterated through using a foreach loop
            Console.WriteLine ("List of Names:");
            foreach (string names in List1) {
                Console.WriteLine ("-" + names);
            }
            System.Console.WriteLine (" ");
            //--------------------------------------------------------------------------------------------------------------

            // Dictionary Class 
            Dictionary<string, string> myDict = new Dictionary<string, string> ();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            myDict.Add ("Name", "Mohammed");
            myDict.Add ("Language", "ASP.NET");
            myDict.Add ("Location", "Jeddah");
            Console.WriteLine ("About Me");
            // Console.WriteLine ("Name - " + myDict["Name"]);
            // Console.WriteLine ("From - " + myDict["Location"]);
            // Console.WriteLine ("Favorite Language - " + myDict["Language"]);

            //Same Output .....
            foreach (KeyValuePair<string, string> entry in myDict) {
                Console.WriteLine (entry.Key + " - " + entry.Value);
            }
            //The var keyword takes the place of a type in type-inference
            // foreach (var entry in myDict) {
            //     Console.WriteLine (entry.Key + " - " + entry.Value);
            // }
            System.Console.WriteLine (" ");

            //------------------------------------------------------------------------------------
            // Collections Practice (Three Basic Arrays)
            // Create an array to hold integer values 0 through 9
            int[] PracArray;
            PracArray = new int[10];
            for (int i = 0; i < PracArray.Length; i++) {
                PracArray[i] = i;
                Console.Write (PracArray[i] + " ");
            }
            Console.WriteLine ("");
            Console.WriteLine ("");

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] myFriends = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            for (int idx = 0; idx < myFriends.Length; idx++) {
                Console.Write (myFriends[idx] + " ");
            }
            Console.WriteLine ("");
            Console.WriteLine ("");

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] new_array = new bool[10];
            int Prastart = 0;
            int Pend = new_array.Length;
            for (int i = start; i < end; i += 2) {
                new_array[i] = true;
                new_array[i + 1] = false;
            }
            foreach (bool x in new_array) {
                Console.Write ($"{x} ");
            }
            Console.WriteLine ("");
            Console.WriteLine ("");


        }
    }
}