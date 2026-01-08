using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Program: StudentMarksAnalyzer.cs
             * Author: Mfanelo Mathye
             * Date: 2023
             * Description: Analyzes test marks to calculate statistics including pass/fail rates,
             *              highest/lowest marks, and average of passing marks.
             */

            // Test marks array containing 30 student test scores (0-100%)
            int[] testMarks = new int[30] {70, 81, 72, 40, 99, 10, 23, 26, 55, 34,
                               88, 10, 27, 32, 54, 75, 91, 93, 82, 64,
                               67, 15, 39, 49, 50, 24, 68, 62, 80, 47};

            // Initialize counters for pass/fail statistics
            int coutFail = 0, countPass = 0;  // Note: coutFail has a typo (should be countFail)

            // PHASE 1: Calculate Pass/Fail Rates
            // ----------------------------------
            // Iterate through all marks and count passes (≥50) and fails (<50)
            foreach (int mark in testMarks)
            {
                if (mark >= 50)
                    countPass++;      // Increment pass counter
                else
                    coutFail++;       // Increment fail counter
            }//End foreach 

            // Calculate and display pass/fail rates as percentages
            // {0:P0} formats as percentage with 0 decimal places
            Console.WriteLine("Pass Rate: {0:P0}", (double)countPass / testMarks.Length);
            Console.WriteLine("Fail Rate: {0:P0}", (double)coutFail / testMarks.Length);

            // PHASE 2: Find Highest and Lowest Marks
            // ---------------------------------------
            // Initialize with first element for comparison
            int highestMark = testMarks[0];
            int lowestMark = testMarks[0];

            // Iterate through marks to find extremes
            foreach (int mark in testMarks)
            {
                // Update highest mark if current mark is greater
                if (mark > highestMark)
                    highestMark = mark;

                // Update lowest mark if current mark is smaller
                if (mark < lowestMark)
                    lowestMark = mark;
            }//end foreach 

            // Display the highest and lowest marks
            Console.WriteLine("Highest Mark: {0}%", highestMark);
            Console.WriteLine("Lowest Mark: {0}%", lowestMark);

            // PHASE 3: Calculate Average of Passing Marks
            // --------------------------------------------
            // Variables for average calculation
            int totalMarks = 0, passCount = 0;
            double average;

            // Sum only passing marks (≥50) and count them
            foreach (int mark in testMarks)
            {
                if (mark >= 50)
                {
                    totalMarks += mark;     // Add mark to total
                    passCount++;           // Increment passing marks counter
                }
            }//end foreach 

            // Calculate and display average, handling case where no one passed
            if (passCount != 0)
            {
                // Cast to double for precise division, then format to 2 decimal places
                average = (double)totalMarks / passCount;
                Console.WriteLine("Average Pass Mark: {0:F2}% ", average);
            }
            else
            {
                // Edge case: no passing marks in the dataset
                Console.WriteLine("Nobody passed!");
                Console.ReadLine();


            }

            // END OF PROGRAM


        }
    }
}
