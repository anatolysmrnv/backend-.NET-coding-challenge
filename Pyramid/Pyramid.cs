using System;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height, int row = 0)
        {
            // Base case: If we have reached the last row, print it and return
            if (row == height)
            {
                PrintRow(height, row);
                return;
            }

            // Print the current row
            PrintRow(height, row);

            // Recurse to the next row
            Pyramid(height, row + 1);
        }

        private static void PrintRow(int height, int row)
        {
            // Calculate the number of spaces and asterisks to print
            int spaces = height - row - 1;
            int asterisks = 2 * row + 1;

            // Print the leading spaces
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }

            // Print the asterisks
            for (int i = 0; i < asterisks; i++)
            {
                Console.Write("*");
            }

            // Move to the next line
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}