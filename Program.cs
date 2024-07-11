using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[50];

            Console.WriteLine("elements before insertion: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i]+ " ");
            }

            Console.Write("\nEnter position for insertion of element: ");
            int pos = int.Parse(Console.ReadLine());
            Console.Write("Enter value to be inserted : ");
            int value = int.Parse(Console.ReadLine());

            if (pos < 0 || pos > size + 1)
            {
                Console.WriteLine("invalid position");
            }
            else
            {
                for (int i = size - 1; i >= pos - 1; i--)
                {
                    array[size + 1] = array[size];
                }
                array[pos-1] = value;
                size++;
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}