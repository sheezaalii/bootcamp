using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
            //Have the function ArrayAddition1(arr) take the array of numbers stored in arr 
            //and return the string true if any combination of numbers in the array[excluding the Largest number) 
            //can be added up to equal the largest number in the array, otherwise retum the string false.
            //For example if arr contains[4, 6, 23, 10, 1, 3] then output should return true because 4 + 6 + 10 + 3 = 23.
            //The array will not be empty, will not contain all the same elements, and may contains negative numbers.
    internal class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool ArrayAddition1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

            }
            return true;
        }

        public static int Largest(int[] arr) 
        {
            int largest = 0;
            for (int i = 0; i < arr.Length; i++) 
            { 
                if(arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }

       
    }
}