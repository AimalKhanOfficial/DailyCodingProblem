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
            This problem was asked by Uber.

            Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
            
            For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
            
            Follow-up: what if you can't use division? 
        */
        public static void Main(string[] args)
        {
            CreateNewArrayLinear(new int[] { 1, 2, 3, 4, 5 });
            Console.ReadKey();
        }

        public static int[] CreateNewArrayLinear(int[] arr)
        {
            var firstArr = new int[arr.Length];
            var p = 1;
            
            for (var i = 0; i < arr.Length; i++)
            {
                firstArr[i] = p;
                p *= arr[i];
            }

            var secondArr = new int[arr.Length];
            p = 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                secondArr[i] = p;
                p *= arr[i];
            }

            var finalArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                finalArr[i] = firstArr[i] * secondArr[i];
            }
            return finalArr;
        }

        //O(N2)
        public static int[] CreateNewArray(int[] arr)
        {
            var newArr = new int[arr.Length];
            var valueToTake = 0;
            var total = 1;
            var j = 0;
            for (var i = 0; i < newArr.Length; i++)
            {
                total = 1;
                valueToTake = i + 1;
                j = 0;
                while (j < arr.Length - 1)
                {
                    if (valueToTake == arr.Length)
                    {
                        valueToTake = 0;
                    }
                    total *= arr[valueToTake];
                    valueToTake++;
                    j++;
                }
                newArr[i] = total;
            }
            return newArr;
        }
    }
}
