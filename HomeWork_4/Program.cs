using System;

namespace HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new(15, 5, 90);
            building1.ShowInfo();
            Building building2 = new(25, 25, 150);
            building2.ShowInfo();
            Building building3 = new(60, 2, 400);
            building3.ShowInfo();
            Building building4 = new(70, 15, 50);
            building4.ShowInfo();
            Building building5 = new(15, 5, 300);
            building5.ShowInfo();
        }
    }
}
