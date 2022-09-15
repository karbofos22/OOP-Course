using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    internal class Acoder : ICoder
    {
        //    Создать класс ACoder, реализующий интерфейс ICoder.
        //    Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
        //    (В результате такого сдвига буква А становится буквой Б). 

        readonly char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public string Decode(string encodedString)
        {
            string decodedString = "";

            foreach (char item in encodedString)
            {
                if (alphabet.Contains(item))
                {
                    int index = Array.IndexOf(alphabet, item);
                    if (index == 0)
                    {
                        index = alphabet.Length;
                    }
                    decodedString += alphabet[index - 1];
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
                    if (index == alphabet.Length - 1)
                    {
                        index = -1;
                    }
                    encodedString += alphabet[index+1];
                }
            }
            return encodedString;
        }
    }
}
