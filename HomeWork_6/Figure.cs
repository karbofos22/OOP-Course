using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal abstract class Figure
    {
        //2. * Создать класс Figure для работы с геометрическими фигурами.
        //В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». 
        //Реализовать операции:
        //передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый). 
        //Метод вывода на экран должен выводить состояние всех полей объекта.
        //Создать класс Point (точка) как потомок геометрической фигуры.Создать класс Circle (окружность) как потомок точки. 
        //В класс Circle добавить метод, который вычисляет площадь окружности. 
        //Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
        //Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.

        protected bool isVisible;
        protected Colors color;
        protected float xPos, yPos;

        public float MoveByX(float num)
        {
            return xPos = num;
        }
        public float MoveByY(float num)
        {
            return yPos = num;
        }
        public Colors ChangeColor(Colors newColor)
        {
            return color = newColor;
        }
        public bool GetVisibilityStatus()
        {
            if (isVisible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Позиция по X: {xPos}\n" +
                              $"Позиция по Y: {yPos}\n" +
                              $"Видимость: {isVisible}\n" +
                              $"Цвет: {color}");
        }
    }
}
