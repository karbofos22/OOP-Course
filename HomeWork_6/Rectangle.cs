using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Rectangle : Point
    {
        private float SideA { get; set; }
        private float SideB { get; set; }
        private float RectangleArea { get; set; }

        /// <summary>
        ///  sideA - длина стороны А прямоуголника<br/> 
        ///  sideB - длина стороны B прямоуголника<br/> 
        ///  positionX - позиция по X координате<br/>  
        ///  positionY - позиция по Y координате<br/>  
        ///  setColor - выбрать цвет из перечисления<br/>  
        ///  visibility - выбрать значение видимости обьекта из перечисления
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="setColor"></param>
        /// <param name="visibility"></param>
        /// 
        public Rectangle(float sideA, float sideB, float positionX, float positionY, Colors setColor, Visibility visibility) : base(positionX, positionY, setColor, visibility)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public float GetRectangleArea()
        {
           return RectangleArea = SideA * SideB;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Длина стороны А: {SideA} см\n" +
                              $"Длина стороны B: {SideB} см\n" +
                              $"Площадь прямоугольника: {RectangleArea} см2");
        }
    }
}
