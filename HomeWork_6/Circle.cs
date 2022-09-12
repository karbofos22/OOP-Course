using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Circle : Point
    {
        const double Pi = 3.14;
        private double CircleArea { get; set; }
        private int Radius { get; set; }

        /// <summary>
        ///  positionX - позиция по X координате<br/>  
        ///  positionY - позиция по Y координате<br/>  
        ///  setColor - выбрать цвет из перечисления<br/>  
        ///  visibility - выбрать значение видимости обьекта из перечисления<br/>  
        ///  radius - радиус окружности в см.
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="setColor"></param>
        /// <param name="visibility"></param>
        /// <param name="radius"></param>
        /// 
        public Circle(float positionX, float positionY, Colors setColor, Visibility visibility, int radius) : base(positionX, positionY, setColor, visibility)
        {
            Radius = radius;
        }
        public double GetCircleArea()
        {
            Radius *= Radius;
            return CircleArea = Radius * Pi;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Радиус: {Radius} см");
            Console.WriteLine($"Площадь окружности: {CircleArea} см2");
        }
    }
}
