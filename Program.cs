using System;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers seperated by a comma:  ");
            string userInput = Console.ReadLine();
            string[] nums = userInput.Split(',');
            int[] terms = new int[4];

            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    int result = Int32.Parse(nums[i]);
                    terms[i] = result;
                }
                catch
                {
                    int result = 0;
                    terms[i] = result;
                }
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
