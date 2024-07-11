using System;

namespace MyApp
{
    internal class Program 
    {
        //String to ASCII code
        public static string StringToAscii(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    result += " ";
                }
                else 
                { 
                result += (int)str[i];
                }
            }
            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            Console.WriteLine(StringToAscii(Console.ReadLine()));


        }
    }
}