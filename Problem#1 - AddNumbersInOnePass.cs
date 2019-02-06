using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        /*
         
          Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

          For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
          
          Bonus: Can you do this in one pass?
          
         */

        static void Main(string[] args)
        {
            Console.WriteLine(CheckNumbersIfTheyAddUp(new int[] { 10, 15, 3, 7 }, 17));
            Console.ReadKey();
        }

        //Copied from StackOverflow (https://stackoverflow.com/questions/51300360/given-a-list-of-numbers-and-a-number-k-return-whether-any-two-numbers-from-the)
        //Cool Solution
        public static bool containsPairWithSum(int[] a, int x)
        {
            Array.Sort(a);
            for (int i = 0, j = a.Length - 1; i < j;)
            {
                int sum = a[i] + a[j];
                if (sum < x)
                    i++;
                else if (sum > x)
                    j--;
                else
                    return true;
            }
            return false;
        }

        //My Solution in O(N^2)
        public static bool CheckNumbersIfTheyAddUp(int[] arr, int target)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
