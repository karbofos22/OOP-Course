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

        //Constanses
            //Minimum building height
        const int minHeigth = 10;
            //Floors const values
        const int minFloorsCount = 1;
        const int minFloorHeight = 3;
        const int maxFloorHeight = 5;
        //Total flats const values
        const int minTotalFlats = 50;
        //Flats at floor const values
        const int minFlatsAtFloor = 3;
        const int maxFlatsAtFloor = 8;

        readonly int buildingStartingNum = 1;
        private static int TotalBuildingsNum { get; set; }
        private int Num { get; set; }
        
        private int TotalHeight { get; set; }
        private int FloorsCount { get; set; }
        private int FlatsCount { get; set; }
        private int FlatsAtFloor { get; set; }
        private int CeilingHeight { get; set; }
        private int EntrancesCount { get; set; }

        public Building(int height, int floorsCount, int flatsCount)
        {
            AssignBuildingNum();
            HeightSetup(height);
            FloorsSetup(floorsCount);
            FlatsSetup(flatsCount);
            EntrancesSetup();
            FlatsAtFloorSetup();
            CeilingHeightSetup();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Параметры здания:\n" +
                             $"Высота: {TotalHeight}\n" +
                             $"Кол-во этажей: {FloorsCount}\n" +
                             $"Кол-во подъездов: {EntrancesCount}({FlatsCount / EntrancesCount} квартир(ы) в подъезде)\n" +
                             $"Кол-во квартир: {FlatsCount}({FlatsAtFloor} квартир(ы) на этаж)\n" +
                             $"Высота потолка в квартире: {CeilingHeight}\n" +
                             $"Порядковый номер дома: {Num}\n");
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
        int FloorsSetup(int floorsCount)
        {
            if (floorsCount <= 0)
            {
                return FloorsCount = minFloorsCount;
            }
            else if(TotalHeight / floorsCount <= minFloorHeight)
            {
                return FloorsCount = TotalHeight / minFloorHeight;
            }
            else if(TotalHeight / floorsCount >= maxFloorHeight)
            {
                return FloorsCount = TotalHeight / maxFloorHeight;
            }
            else
            {
                return FloorsCount = floorsCount;
            }
        }
        int FlatsSetup(int flatsCount)
        {
            return flatsCount <= 15 ? FlatsCount = minTotalFlats : FlatsCount = flatsCount;
        }
        void EntrancesSetup()
        {
                EntrancesCount = FlatsCount / minFlatsAtFloor / FloorsCount;

            if (EntrancesCount > 10)
            {
                EntrancesCount = FlatsCount / FloorsCount / maxFlatsAtFloor;
            }
        }

        int FlatsAtFloorSetup()
        {
            return FlatsAtFloor = FlatsCount / EntrancesCount / FloorsCount;
        }
        int CeilingHeightSetup()
        {
            return CeilingHeight = TotalHeight / FloorsCount;
        }
        void AssignBuildingNum()
        {
            if (TotalBuildingsNum == 0)
            {
                Num = buildingStartingNum;
                TotalBuildingsNum += 2;
            }
            else
            {
                Num = TotalBuildingsNum;
                TotalBuildingsNum++;
            }
        }
    }
}
