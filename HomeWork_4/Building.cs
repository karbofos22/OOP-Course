using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Building
    {
        //1. Реализовать класс для описания здания(уникальный номер здания, высота, этажность, количество квартир, подъездов). 
        //    Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
        //    Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
        //    Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
        //    Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, 
        //    и предусмотреть метод, который увеличивал бы значение этого поля.

        readonly int buildingStartingNum = 0;
        private static int TotalBuildingsNum { get; set; }
        
        private int Num { get; set; }
        readonly int minHeigth = 7;
        readonly double minFloorHeight = 2.5f;
        private int TotalHeight { get; set; }
        private int FloorsCount { get; set; }
        private int FlatsCount { get; set; }
        private int EntrancesCount { get; set; }
        private List<int> Floor { get; set; }
        private List<int> Flat { get; set; }
        private List<int> Entrance { get; set; }


        public Building(int height, int floorsCount, int flatsCount, int entrancesCount)
        {
            AssignBuildingNum();
            HeightSetup(height);
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("Параметры здания:\n" +
                             $"Высота: {TotalHeight}\n" +
                             $"Кол-во этажей: {FloorsCount}\n" +
                             $"Кол-во подъездов: {EntrancesCount}\n");
        }
        private double FloorsSetup(int floorsCount)
        {
            if (TotalHeight == minHeigth)
            {
                return FloorsCount = 1;
            }
            else
            {
                if (true)
                {

                }
            }
        }
        int HeightSetup(int height)
        {
            if (height < minHeigth)
            {
                return TotalHeight = minHeigth;
            }
            else
            {
                return TotalHeight = height;
            }
        }
        void AssignBuildingNum()
        {
            if (TotalBuildingsNum == 0)
            {
                Num = buildingStartingNum;
                TotalBuildingsNum++;
            }
            else
            {
                Num = TotalBuildingsNum;
                TotalBuildingsNum++;
            }
        }
    }
}
