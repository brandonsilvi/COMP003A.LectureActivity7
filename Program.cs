using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

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
        }
    }
}