
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine();
            //Question 01 ---> remove duplicate elements 

            int[] array = { 0, 0, 2, 7, 8, 3, 2, 3, 0, 4, 5, 0 };
            Console.Write("Array Before Duplication removal: ");
            PrintArray(array);
            int size = DelDuplicate(array); 
            Console.Write("\nArray After Duplication removal: ");
            for (int i = 0; i < size; i++) {  // Only printing unique elements in array
                Console.Write(array[i] + " "); }
            PrintLine();

            //Question 02 ---> Find Largest and second largest Number

            FirstSecondLargest(array); //taking previous array
            PrintLine();

            //Question 03 ---> move zeros to end of array

            int[] ArrayNew = { 0, 2, 7, 8, 3, 2, 3, 0, 4, 5, 0 };
            Console.Write("Array Before moving zeros: ");
            PrintArray(ArrayNew);
            int[] zeroEnd = MoveZerosToEnd(ArrayNew);  //function call
            Console.Write("\nArray After moving zeros: ");
            PrintArray(zeroEnd);
            PrintLine();

            //Question 04 ---> Find First non repeating chracter in String

            string input = "RandomStringcheck";
            Console.WriteLine("Input String: " + input);
            char firstNonRepeating = FirstNonRepeatingChar(input);
            if (firstNonRepeating != '\0')
            {
                Console.WriteLine("First non repeating: " + firstNonRepeating);
            }
            else
            {
                Console.WriteLine("no non repeated char found");
            }
            PrintLine();

            //Question 05 ---> Merge sorted arrays

            int[] A = { 1, 3, 5, 7 };
            int[] B = { 2, 4, 6, 8 };

            Console.Write("Array A: ");
            PrintArray(A);
            Console.Write("Array B: ");
            PrintArray(B);

            int[] MergedArray = MergeSortedArrays(A, B);
            Console.WriteLine("Merged Array: ");
            PrintArray(MergedArray);
            PrintLine();

            //Question 06 ---> Find Missing number

            int[] randArray = { 3, 0, 1, 4 };
            PrintArray(randArray);
            int missingNumber = FingMissingNumber(randArray);
            Console.WriteLine($"The missing number is: {missingNumber}");
            PrintLine();

            // Question 07 --- check Armstrong number
            int number = 351;
            bool isArmstrong = IsArmstrongNumber(number);
            if (isArmstrong)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
            PrintLine();

            // Question 08 --- find the longest common prefix in an array of strings

            string[] inputStrings = { "interstellar", "internet", "intermediate","intermission" };
            string longestCommonPrefix = FindLongestCommonPrefix(inputStrings);
            Console.WriteLine($"Longest common prefix: {longestCommonPrefix}");
            PrintLine();

            // Question 09 --- Fabonacci sequence

            Console.Write("Enter the number of terms for Fibonacci sequence: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + ", ");
            }
            PrintLine();

            // Question 10 --- calculate Positives, Negatives , sum, average

            Console.Write("Enter the number of integers: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int positiveCount = 0, negativeCount = 0;
            int total = 0;
            double average = 0.0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;

                total += num;
            }

            if (N > 0)
                average = (double)total / N;
            PrintLine();


            Console.WriteLine($"Positive numbers: {positiveCount}");
            Console.WriteLine($"Negative numbers: {negativeCount}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
            PrintLine();
        }


        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static int DelDuplicate(int[] arr)
        {
            //sort array first
            Array.Sort(arr);
            // using only ONE array by keeping a extra variable (temp) pointing at array
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[temp] != arr[i])
                {
                    temp++;
                    arr[temp] = arr[i];
                }
            }
            return temp + 1;
        }

        public static void FirstSecondLargest(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Array must have at least two elements.");
                return;
            }
            int largest = arr[0];
            int secondLargest = int.MinValue;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine($"Largest : {largest}");
            Console.WriteLine($"Second Largest : {secondLargest}");
        }

        public static int[] MoveZerosToEnd(int[] arr)
        {
            int nonZero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {   //traverse array if elememt is non-zero
                    arr[nonZero] = arr[i]; //replace it with nonzero-index
                    nonZero++;
                }
            }

            // when we have all the non zero elements when can then replace the remaining one with zeros
            for (int i = nonZero; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

        public static char FirstNonRepeatingChar(string str)
        {
            int[] charCount = new int[256]; //taking 256 for taking All ASCII characters into count 

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i]; //xhar at position i
                charCount[currentChar]++;   //count frequency of each char
            }

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (charCount[currentChar] == 1) //checking first one with 1 frequency
                {
                    return currentChar;
                }
            }

            return '\0';
        }

        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int[] merge = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    merge[k] = arr1[i];
                    i++;
                }
                else
                {
                    merge[k] = arr2[j];
                    j++;
                }
                k++;
            }

            //make sure there is no elemet left 
            //Copying remaining elements 

            while (i < arr1.Length)
            {
                merge[k] = arr1[i];
                i++;
                k++;
            }

            //Copying remaining elements 
            while (j < arr2.Length)
            {
                merge[k] = arr2[j];
                j++;
                k++;
            }
            return merge;
        }

        public static int FingMissingNumber(int[] arr)
        {
            int n = arr.Length;
            int totalExpectedSum = n * (n + 1) / 2;
            int arraySum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arraySum = arraySum + arr[i];
            }

            return totalExpectedSum - arraySum;
        }

        public static bool IsArmstrongNumber(int num)
        {
            int originalNum = num;
            int sum = 0;
            int digits = CountDigits(num);

            while (num != 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }

            return sum == originalNum;
        }

        public static int CountDigits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }

        public static string FindLongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0)
                        return "";
                }
            }
            return prefix;
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void PrintLine()
        {
            Console.WriteLine("\n--------------------------------------------");
        }
            
            
     }

}