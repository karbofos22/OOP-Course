using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    internal interface ICoder
    {
        //1.Определить интерфейс IСoder, который полагает методы поддержки шифрования строк.
        //  В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк. 
        string Encode(string someString);
        string Decode(string someString);
    }
}
