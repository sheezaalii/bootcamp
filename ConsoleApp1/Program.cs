using System;

namespace HelloWorld
{
    class Program
    {
        //question 01
        static int SumNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        //question 02
        static void EvenNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        // question 03

        static string LeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return "Leap Year";
            }
            else if (year % 100 == 0)
            {
                return "Not a Leap Year";
            }
            else if (year % 4 == 0)
            {
                return "Leap Year";
            }
            else
            {
                return "Not a Leap Year";
            }
        }

        //question 04

        static double Conversion(double value)
        {
            double new_value = value * 0.6213721;
            return new_value;
        }

        //question 05

        static string BuzzNum(int num)
        {
            if (num % 7 == 0 || num % 10 == 7)
            {
                return "It is a Buzz number";
            }
            else
            {
                return "It is not a Buzz number";
            }

        }
        //question 06

        static void Table(int num)
        {
            for(int  i = 1; i <= 10; i++)
            {
                int table = num * i;
                Console.WriteLine(num + " X " + i + "= " + table);
            }
        }

        //question 07

        static int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else 
            {
                int result = 1;
                for (int i = 2; i <= num; i++)
                {
                    result *= i;
                }
                return result;        
            }
        }

        //question 08

        static string IsPrime(int num)
        {
            bool Prime = true;

            if (num <= 1)
            {
                Prime = false;
            }
            else
            {
                int Counter = num / 2;
                while (Counter >= 2)
                {
                    if (num % Counter == 0)
                    {
                        Prime = false;
                        break;
                    }
                    Counter--;
                }
            }

            if (Prime)
            {
                return "Prime";
            }
            else
            {
                return "Not Prime";
            }
        }

        //question 09

        static string CheckTriangleType(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral triangle";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles triangle";
            }
            else
            {
                return "Scalene triangle";
            }
        }

        //question 10

        static void Pattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        // question 11 Bounus


        static void Main(string[] args)
        {
                //sum of numbers ---> 01

            Console.Write("Enter number 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter number 2: ");
            string input2 = Console.ReadLine();
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int sum = SumNumbers(num1, num2);
            Console.Write("Sum of numbers = " + sum);
            Console.Write("\n\n============================== \n\n");

                // Print even numbers from 1 to 100 ---> 02

            Console.WriteLine("Even numbers from 1 to 100: \n");
            EvenNumbers();

            Console.Write("\n\n============================== \n\n");

                // check if given year is Leap year or not ---> 03

            Console.Write("Enter year = ");
            string year = Console.ReadLine();
            int Year = int.Parse(year);
            string Leapyear = LeapYear(Year);
            Console.Write(Leapyear);

            Console.Write("\n\n============================== \n\n");

                // KMPH to MPH ---> 04

            Console.Write("Enter number value in KMPH = ");
            string input = Console.ReadLine();
            double value = Convert.ToDouble(input);
            double MPH = Conversion(value);
            Console.WriteLine("Value in MPH = " + MPH);

            Console.Write("\n\n==============================\n\n");

                //Buzz Number or not ---> 05

            Console.Write("Enter a number to check if it is Buzz number or not : ");
            string check = Console.ReadLine();
            int buzz = int.Parse(check);
            string Buzz = BuzzNum(buzz);
            Console.WriteLine(Buzz);

            Console.Write("\n\n==============================\n\n");

                // Print table of a number ---> 06

            Console.Write("Enter Number to print table = ");
            string number = Console.ReadLine();
            int number2 = int.Parse(number);
            Table(number2);

            Console.Write("\n\n==============================\n\n");

            //Factorial ---> 07

            Console.Write("Enter Number to find its factorial = ");
            string fact = Console.ReadLine();
            int factorial = int.Parse(fact);
            int result = Factorial(factorial);
            Console.WriteLine("---> " + result);

            Console.Write("\n\n==============================\n\n");

                //Prime number  ---> 08
            Console.Write("Enter a number to check if it is Prime or not: ");
            string primeCheck = Console.ReadLine();
            int primeNum = int.Parse(primeCheck);
            string PrimeResult = IsPrime(primeNum);
            Console.WriteLine(PrimeResult);

            Console.WriteLine("\n\n==============================\n\n");

                //Triangle types  ---> 09

            Console.Write("Enter length of side 1: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter length of side 2: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.Write("Enter length of side 3: ");
            int side3 = int.Parse(Console.ReadLine());

            string triangleType = CheckTriangleType(side1, side2, side3);
            Console.WriteLine("---> " + triangleType);

            Console.WriteLine("\n\n==============================\n\n");

            //Triangle star pattern  ---> 10

            Pattern();

            Console.WriteLine("\n\n==============================\n\n");

            //Palindrome  ---> 11


        }
    }
}
