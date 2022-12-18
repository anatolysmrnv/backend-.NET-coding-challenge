using System;
using System.Text;

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
        private static void Pyramid(int height, int row = 0, StringBuilder sb = null)
        {
            // Create a new StringBuilder on the first call
            if (sb == null)
            {
                sb = new StringBuilder();
            }

            // Base case: If we have reached the last row, print it and return
            if (row == height - 1)
            {
                PrintRow(height, row, sb);
                Console.WriteLine(sb.ToString());
                return;
            }

            // Print the current row
            PrintRow(height, row, sb);

            // Recurse to the next row
            Pyramid(height, row + 1, sb);
        }

        private static void PrintRow(int height, int row, StringBuilder sb)
        {
            //Calculate the total row length
            int rowLength = 2 * height - 1; 

            // Make note of the indices in the pyramid row where spaces first end and asterisks end.
            int spacesEndPostion = height - 1 - row;
            int asterisksEndPostion = height - 1 + row;

            for (int i = 0; i < rowLength; i++ )
            {
                // Inline append to the string builder based on where we are in the row
                sb.Append((i < spacesEndPostion || i > asterisksEndPostion) ? ' ' : '*');
            }

            // Move to the next line
            sb.AppendLine();
        }

        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}