using System;
using System.Collections.Generic;

/**
 *
 * Given is the following FizzBuzz application which counts from 1 to 100 and outputs either the corresponding
 * number or the corresponding text if one of the following rules apply.
 * Rules:
 *  - dividable by 3 without a remainder -> Fizz
 *  - dividable by 5 without a remainder -> Buzz
 *  - dividable by 3 and 5 without a remainder -> FizzBuzz
 *
 * ACCEPTANCE CRITERIA:
 * Please refactor this code so that it can be easily extended in the future with other rules, such as
 * "if it is dividable by 7 without a remainder output Bar"
 * "if multiplied by 10 is larger than 100 output Foo"
 *
 */

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        //this is a list of tuples for initial FizzBuzz rules
        private List<(Func<int, bool> condition, string output)> rules = new List<(Func<int, bool> condition, string output)>
        {
            (i => i % 3 == 0, "Fizz"),
            (i => i % 5 == 0, "Buzz")
        };
        //this method allows adding new rules by giving it a condition as a function delegate and the output
        public void AddRule(Func<int, bool> condition, string output)
        {
            rules.Add((condition, output));
        }

        //the main method that executes the rule check on the amount of numbers specified by the limit
        public void Run(int limit = 100)
        {
            //example of the AddRule function in action using the suggestions from the description
            AddRule(i => i * 10 > 100, "Foo");
            AddRule(i => i % 7 == 0, "Bar");

            //for each number, check if a rule applies and print the result, otherwise print the number
            for (int i = 1; i <= limit; i++)
            {
                string output = "";
                foreach (var rule in rules)
                {
                    if (rule.condition(i))
                    {
                        output += rule.output;
                    }
                }

                if (string.IsNullOrEmpty(output))
                {
                    output = i.ToString();
                }

                Console.WriteLine("{0}: {1}", i, output);
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzEngine engine = new FizzBuzzEngine();
            engine.Run();
        }
    }
}
