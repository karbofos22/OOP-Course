using System;

namespace HomeWork_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RatioNumber num1 = new(3, 4);
            RatioNumber num2 = new(8, 5);
            RatioNumber num3 = new(13, 6);
            RatioNumber num4 = new(7, 2);
            RatioNumber num5 = new(5, 5);
            RatioNumber num6 = new(5, 5);
            RatioNumber num7 = new(13, 23);

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3 - num4);
            Console.WriteLine(num5 == num6);
            Console.WriteLine(num3 != num4);
            Console.WriteLine(num3 > num4);
            Console.WriteLine(num3 < num4);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num3);
            Console.WriteLine(num1++);
            Console.WriteLine(num1--);
            Console.WriteLine(num5.Equals(num6));
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine((float)num7);
            Console.WriteLine((int)num3);
        }
    }
}
