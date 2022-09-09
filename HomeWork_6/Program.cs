using System;

namespace HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new(13.2f, 5f, Colors.Yellow, Visibility.False);
            point.ShowInfo();
            Console.WriteLine();

            point.MoveByX(-24);
            point.ChangeColor(Colors.Red);
            point.GetVisibilityStatus();
            point.ShowInfo();
            Console.WriteLine();

            Circle circle = new(24f, 35f, Colors.Blue, Visibility.True, 14);
            circle.GetCircleArea();
            circle.ShowInfo();
            Console.WriteLine();

            circle.MoveByY(5f);
            circle.ChangeColor(Colors.Green);
            circle.ShowInfo();
            Console.WriteLine();

            Rectangle rectangle = new(15f, 25f, 11f, 41f, Colors.Black, Visibility.False);
            rectangle.GetRectangleArea();
            rectangle.ChangeColor(Colors.Red);
            rectangle.ShowInfo();
        }
    }
}
