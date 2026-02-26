using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace COMP003A.LectureActivity7
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------- A) Array

            int[] scores = { 85, 90, 708, 92, 88 };
            
            Console.WriteLine("Array values using for loop");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
            
            // ----------- B) List

            List<string> names = new List<string>();

            names.Add("Justin");
            names.Add("Brian");
            names.Add("Liam");

            Console.WriteLine("\nList calues using foreach:");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
            // -------- C) for with List
            
            Console.WriteLine("\nList values using for loop:");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            } 
            
            // Part D and E : input and try-catch
            
            Console.Write("\nEnter a number between 1 and 3: ");
            string input = Console.ReadLine();

            try
            {
                int choice = int.Parse(input);

                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("Valid choice");
                }
                else
                {
                    Console.WriteLine("Number out of range.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered.");
            }
        }
    }
}

