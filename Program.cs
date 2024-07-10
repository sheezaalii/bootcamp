using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int loop;
            do
            {
                Console.WriteLine("Enter number to call the functions:");
                Console.WriteLine("0- Print sum of two numbers\n" +
                    "1- Print all even numbers from 1 to 100\n" +
                    "2- Check Leap year\n" +
                    "3- Convert KM/H to Miles/H\n" +
                    "4- check buzz Number\n" +
                    "5- Multiplication\n" +
                    "6- Factorial\n" +
                    "7- Check Prime Number\n" +
                    "8- Check Triangle by sides\n" +
                    "9- Check Pattern\n" +
                    "10- Check Palindrome\n");
                int Input = Convert.ToInt32(Console.ReadLine());
                switch (Input)
                {

                    case 0:
                        PrintSum();
                        break;
                    case 1:
                        PrintEven();
                        break;
                    case 2:
                        Leapyear();
                        break;
                    case 3:
                        KmphToMph();
                        break;
                    case 4:
                        Buzz_number();
                        break;
                    case 5:
                        Multiplication();
                        break;
                    case 6:
                        Factorial();
                        break;
                    case 7:
                        IsPrime();
                        break;
                    case 8:
                        Triangle();
                        break;
                    case 9:
                        Pattern();
                        break;
                    case 10:
                        Palindrome();
                        break;
                }
                Console.WriteLine("Do you want to perform again? Press 1");
                loop = Convert.ToInt32(Console.ReadLine());
            } while (loop == 1);

        }

        static void PrintSum()
        {
            Console.WriteLine("Enter Two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = num1 + num2;
            Console.WriteLine($"Print of {num1} and {num2} is " + sum);
        }

        static void PrintEven()
        {
            Console.WriteLine("All even numbers from 1 to 100:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Leapyear()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not Leap year");
            }
        }

        static void KmphToMph()
        {
            Console.WriteLine("Enter kmph:");
            double kmph = Convert.ToDouble(Console.ReadLine());
            double mph;
            double kiloMeterPerhour = 0.621371;
            mph = kmph * kiloMeterPerhour;
            Console.WriteLine($"{kmph} km/h is eaqual to {mph} miles/h");
        }

        static void Buzz_number()
        {
            Console.Write("Enter the number to check buzz number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number for condition:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (num % n == 0 || num % 10 == n)
            {
                Console.WriteLine("Buzz number");
            }
            else
            {
                Console.WriteLine("Not a Buzz number");
            }

        }

        static void Multiplication()
        {
            Console.Write("Enter the number for multiplication:");
            int num = Convert.ToInt32(Console.ReadLine());

            int counter = 1;

            int mul = 1;
            while (counter <= 10)
            {
                mul = num * counter;
                Console.WriteLine($"{num} X {counter} = {mul}");
                counter++;
            }
        }

        static void Factorial()
        {
            Console.Write("Enter the number for factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fac = 1;
            int counter = 1;
            while (counter <= num)
            {
                fac = fac * counter;
                counter++;
            }
            Console.WriteLine(fac);
        }

        static void IsPrime()
        {
            bool isPrime = true;
            Console.Write("Enter the number for check prime number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.WriteLine($"{num} is prime number");
            }
            int counter = 2; // 0 and 1 
            while (counter <= num / 2)
            {
                if (num % counter == 0)
                {
                    isPrime = false;
                    break;
                }
                counter++;
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not prime number");
            }
        }

        static void Triangle()
        {
            Console.WriteLine("Enter Three sides of triangle:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            if (x == y && y == z)
            {
                Console.WriteLine("Equilateral triangle");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("Isosceles triangle");
            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }
        }

        static void Pattern()
        {
            Console.WriteLine("Enter number of rows:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) //row
            {
                for (int j = 1; j <= i; j++) //column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                //Console.Write("\n");
            }
        }

        static void Palindrome()
        {
            Console.WriteLine("Enter number to check palindrome:");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int check = num;
            while (num != 0)
            {
                int units = num % 10;
                reverse = (reverse * 10) + units;
                num = num / 10;
            }

            if (reverse == check)
            {
                Console.WriteLine($"{check} is palindrome");
            }
            else
            {
                Console.WriteLine($"{check} is not palindrome");
            }

        }

        //Practice array
        public static int palindrome_arr()
        {
            Console.WriteLine("Enter String to check palindrome:");
            string Input = Console.ReadLine();
            int length = Input.Length;
            Console.WriteLine(Input);
            Console.WriteLine(length);

            int left = 0;
            int right = length - 1;

            while (left < right)
            {
                if (Input[left] == Input[right])
                {
                    Console.WriteLine("Palindrome");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                    break;
                }
            }

            return 0;
        }
    }
}
