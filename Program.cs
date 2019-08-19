using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers seperated by a comma or new line:  ");
            string userInput = Console.ReadLine();
            string[] nums = userInput.Split(
                new[] { ",", "\\n" },
                StringSplitOptions.None
            );

            int[] terms = new int[400];
            var negTerms = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {

                try
                {
                    int result = Int32.Parse(nums[i]);
                    terms[i] = result;

                    if (result < 0)
                    {
                        negTerms.Add(result.ToString());
                    }
                }
                catch
                {
                    int result = 0;
                    terms[i] = result;
                }
            }
            bool isEmpty = negTerms.Count < 1;
            if (!isEmpty) {
                Console.Write("You have entered the following negative numbers: ");
                foreach (var item in negTerms) {
                    Console.Write(item+' ');
                }
                throw new ArgumentOutOfRangeException("No negative numbers allowed.");

            }
            int sum = 0;
            for (int i = 0; i < terms.Length; i++)
            {
                sum += terms[i];
            }
            Console.WriteLine(sum);

        }
    }
}
