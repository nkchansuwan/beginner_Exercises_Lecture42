using System;

namespace Exercises_Lecture42
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Number1To10();

            MaximumOfTwoNumber();

            LandscapeOrPortrait();

            SpeedLimitCamera();
        }

        public static void Number1To10()
        {
            Console.Write("Enter Number : ");
            var number =Convert.ToInt32( Console.ReadLine());

            if (number>0 && number<11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void MaximumOfTwoNumber()
        {
            Console.Write("Enter first number :");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if (number1>number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }

        public static void LandscapeOrPortrait()
        {
            Console.Write("Enter width :");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height :");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width>height)
            {
                Console.WriteLine(Image.Landscape);
            }
            else
            {
                Console.WriteLine(Image.Portrait);
            }
        }

        public static void SpeedLimitCamera()
        {
            Console.Write("Enter speed limit : ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed : ");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed<= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int speedConstand = 5;
                const int maxPoint = 12;
                var point = (speed - speedLimit) / speedConstand;
                if (point<maxPoint)
                {
                    Console.WriteLine(point);
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
