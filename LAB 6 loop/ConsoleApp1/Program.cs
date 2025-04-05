// Grading ID: A1027
// Lab 6
// Due: October 29th 2023
// Course Section: CIS-199-50-4238
// This program simply displays 4 patterns using asterisks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6
{
    internal class Lab6
    {
        static void Main(string[] args)
        {

            const int MAX_ROWS = 10; // Number of rows in the patterns.

            // Pattern A
            WriteLine("Pattern A\n");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Write("*");
                }
                WriteLine();
            }

            // Pattern B
            WriteLine("\nPattern B\n");
            for (int row = MAX_ROWS; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Write("*");
                }
                WriteLine();
            }

            // Pattern C
            WriteLine("\nPattern C\n");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space = 1; space < row; space++)
                {
                    Write(" ");
                }
                for (int star = MAX_ROWS; star >= row; star--)
                {
                    Write("*");
                }
                WriteLine();
            }

            // Pattern D
            WriteLine("\nPattern D\n");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space = MAX_ROWS - row; space >= 1; space--)
                {
                    Write(" ");
                }
                for (int star = 1; star <= row; star++)
                {
                    Write("*");
                }
                WriteLine();

            }
        }
    }
}
