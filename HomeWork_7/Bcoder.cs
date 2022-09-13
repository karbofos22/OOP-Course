using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    internal class Bcoder : ICoder
    {
        //    Создать класс BCoder, реализующий интерфейс ICoder.
        //    Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, 
        //    на букву того же регистра, расположенную в алфавите на i - й позиции с конца алфавита. 
        //    (Например, буква В заменяется на букву Э.
        readonly char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public string Decode(string encodedString)
        {
            string decodedString = "";

            foreach (char item in encodedString)
            {
                if (alphabet.Contains(item))
                {
                    int index = Array.IndexOf(alphabet, item);
                    Array.Reverse(alphabet);
                    decodedString += alphabet[index];
                }
            }
            return decodedString;
        }

        public string Encode(string someString)
        {
            string encodedString = "";

            foreach (char item in someString)
            {
                if (alphabet.Contains(Char.ToUpper(item)))
                {
                    int index = Array.IndexOf(alphabet, Char.ToUpper(item));
                    Array.Reverse(alphabet);
                    encodedString += alphabet[index];
                }
            }
            return encodedString;
        }
    }
}
