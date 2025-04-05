/* 
Grading ID: A1020
Lab 7
Due Date: 11/12/23
Course Section: [Your Course Section]
Description: This program takes a positive integer from the user and generates a square of asterisks of that size using nested loops.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        int numStars;

        Console.WriteLine("Enter the number of stars per side for the square:");
        while (!int.TryParse(Console.ReadLine(), out numStars) || numStars <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer for the number of stars per side:");
        }

        Console.WriteLine($"\n{numStars}x{numStars} Square of Asterisks");
        ShowSquareOfStars(numStars);
    }

    static void ShowSquareOfStars(int numStars)
    {
        for (int i = 0; i < numStars; i++)
        {
            for (int j = 0; j < numStars; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
