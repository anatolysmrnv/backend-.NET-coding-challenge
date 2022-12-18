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
        private static void Pyramid(int height)
        {
            for (int row = 1; row <= height; row++)
            {
                // Print the leading spaces
                for (int i = 0; i < height - row; i++)
                {
                    Console.Write(" ");
                }

                // Print the asterisks
                for (int i = 0; i < 2 * row - 1; i++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}