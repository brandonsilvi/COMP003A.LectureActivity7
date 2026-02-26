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
            
            Console.WriteLine("Array values using for loop");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}