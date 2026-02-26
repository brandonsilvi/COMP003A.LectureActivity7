using System;
using System.Collections.Generic;

namespace COMP003A.LectureActivity7
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------- A) Array

            int[] scores = { 85, 90, 708, 92, 88 };
            
            Console.WriteLine("Array values using for loop:");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
            
            // ----------- B) List

            List<string> names = new List<string>();

            names.Add("Justin");
            names.Add("Brian");
            names.Add("Liam");

            Console.WriteLine("\nList values using foreach:");

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
/*
1. Why is input validation preferred over try-catch when possible?
-It prevets errors before they can occur while also avoiding reduced performance from exceptions.
2. Why is try-catch still necessary in some cases?
-This helps ensure the program doesn't crash when users enter unexpected inputs that validation doesn't catch.
3. How did debugging help you understand loop behavior?
-Debugging enables us to see how the loop variables change during each iteration. It also helped make clear the way 
lists and array elements are used. 
*/

