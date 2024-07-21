////using System;

////namespace MyApp
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            string[] input = { "baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z" };

////            List<List<string>> result = ProcessInput(input);
////            Print(result);

////        }
////        public static List<List<string>> ProcessInput(string[] input)
////        {
////            string target = input[0];
////            List<string> strings = input[1].Split(',').ToList();
////            return Targetstring(target, strings);
////        }

////        public static List<List<string>> Targetstring(string target, List<string> strings)
////        {
////            List<List<string>> result = new List<List<string>>();
////            List<string> current = new List<string>();

////            FindCombinations(target, strings, current, result);
////            return result;
////        }

////        public static void FindCombinations(string target, List<string> strings, List<string> current, List<List<string>> result)
////        {
////            if(target.Length == 0)
////            {
////                result.Add(new List<string>(current));
////                return;
////            }
////            foreach (string s in strings) 
////            { 
////                if(target.StartsWith(s))
////                {
////                    current.Add(s);
////                    FindCombinations(target.Substring(s.Length), strings, current, result);
////                    current.RemoveAt(current.Count - 1);
////                }
////            }
////        }

////        static void  Print(List<List<string>> result)
////         {
////            foreach (var values in result)

////            {
////                Console.WriteLine(string.Join(", ", values));
////                //if (values.Count > 0 && values.Count < 3)
////                //{
////                //    Console.WriteLine(string.Join(", ", values));

////                //}
////            }

////    }
////}
////    }



///////////////////////////////////////////////////////////////////////////



//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] inputArray = { 4, 5, 3, 1, 2, 2 };  // 4 sandwiches, hunger levels {2, 3, 1, 4, 2}
//        int result = MinimizeHunger(inputArray);
//        Console.WriteLine(result);  // Expected output
//    }

//    static int MinimizeHunger(int[] inputArray)
//    {
//        int sandwiches = inputArray[0];
//        int[] hungerLevels = inputArray.Skip(1).ToArray();

//        // Sort the hunger levels in descending order
//        Array.Sort(hungerLevels);
//        Array.Reverse(hungerLevels);

//        // Distribute sandwiches to reduce hunger levels
//        while (sandwiches > 0)
//        {
//            // Find the maximum hunger level
//            int maxIndex = Array.IndexOf(hungerLevels, hungerLevels.Max());

//            // Reduce the maximum hunger level
//            if (hungerLevels[maxIndex] > 0)
//            {
//                hungerLevels[maxIndex]--;
//                sandwiches--;
//            }

//            // Re-sort to ensure we always reduce the highest level next
//            Array.Sort(hungerLevels);
//            Array.Reverse(hungerLevels);
//        }

//        // Calculate the difference between the maximum and minimum hunger levels after distribution
//        int maxHunger = hungerLevels.Max();
//        int minHunger = hungerLevels.Min();

//        return maxHunger - minHunger;
//    }
//}






public class Solution
{

}