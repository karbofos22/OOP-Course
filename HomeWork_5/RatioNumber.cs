using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class RatioNumber
    {
        //1.  Создать класс рациональных чисел.В классе два поля – числитель и знаменатель.Предусмотреть конструктор. 
        //    Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --. 
        //    Переопределить метод ToString() для вывода дроби.
        //    Определить операторы преобразования типов между типом дробь,float, int. Определить операторы *, /, %.

        int numerator;
        int denominator;

        public RatioNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static RatioNumber operator + (RatioNumber num1, RatioNumber num2)
        {
            return new RatioNumber (num1.numerator * num2.denominator + num2.numerator * num1.denominator, num1.denominator * num2.denominator);
        }
        public static RatioNumber operator -(RatioNumber num1, RatioNumber num2)
        {
            return new RatioNumber(num1.numerator * num2.denominator - num2.numerator * num1.denominator, num1.denominator * num2.denominator);
        }
        public static RatioNumber operator *(RatioNumber num1, RatioNumber num2)
        {
            return new RatioNumber(num1.numerator * num2.numerator, num1.denominator * num2.denominator);
        }
        public static RatioNumber operator /(RatioNumber num1, RatioNumber num2)
        {
            return new RatioNumber(num1.numerator * num2.denominator, num1.denominator * num2.numerator);
        }
        public static bool operator ==(RatioNumber num1, RatioNumber num2)
        {
            if (num1.numerator == num2.numerator && num1.denominator == num2.denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(RatioNumber num1, RatioNumber num2)
        {
            return !(num1 == num2);
        }
        public static bool operator >(RatioNumber num1, RatioNumber num2)
        {
            if (num1.numerator > num2.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(RatioNumber num1, RatioNumber num2)
        {
            if (num1.numerator < num2.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(RatioNumber num1, RatioNumber num2)
        {
            if (num1.numerator >= num2.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(RatioNumber num1, RatioNumber num2)
        {
            if (num1.numerator < num2.numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static RatioNumber operator ++(RatioNumber num1)
        {
            return new RatioNumber(num1.numerator + 1, num1.denominator + 1);
        }
        public static RatioNumber operator --(RatioNumber num1)
        {
            return new RatioNumber(num1.numerator - 1, num1.denominator - 1);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RatioNumber))
            {
                return false;
            }
            var number = (RatioNumber)obj;
            return numerator == number.numerator && denominator == number.denominator;
        }
        public static explicit operator float(RatioNumber num1)
        {
            return (float)num1.numerator / num1.denominator;
        }
        public static explicit operator int(RatioNumber num1)
        {
            return num1.numerator / num1.denominator;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
