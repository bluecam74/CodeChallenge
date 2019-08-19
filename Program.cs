using System;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers seperated by a comma:  ");
            string userInput = Console.ReadLine();
            string[] nums = userInput.Split(',');
            int[] terms = new int[4];

            for (int i=0; i<2; i++)
            {
                try {
                    int result = Int32.Parse(nums[i]);
                    terms[i]=result;
                }
                catch 
                {
                    int result = 0;
                    terms[i]=result;
                }
            }
            int sum = terms[0] + terms[1];
            Console.WriteLine(sum);

        }
    }
}
