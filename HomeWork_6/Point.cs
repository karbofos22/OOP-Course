using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Point : Figure
    {
        /// <summary>
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
        public Point(float positionX, float positionY, Colors setColor, Visibility visibility)
        {
            xPos = positionX;
            yPos = positionY;
            isVisible = visibility == Visibility.True ? true : false;
            color = setColor;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Тип объекта: {GetType().Name}");
            base.ShowInfo();
        }
    }
}
