using System;
using System.Collections.Generic;

namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Реализовать метод, который в качестве входного параметра принимает строку string, 
            //  возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.

            string test = "Bobby";
            Console.WriteLine(test);
            Console.WriteLine(StringReverse(test));

            string test1 = "Computer";
            Console.WriteLine(test1);
            Console.WriteLine(StringReverse(test1));

            Console.WriteLine();
            //3.* Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес.
            //Разделителем между ФИО и адресом электронной почты является символ &: Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич &Pasha@mail.ru 
            //Сформировать новый файл, содержащий список адресов электронной почты. 
            //Предусмотреть метод, выделяющий из строки адрес почты. 
            //Методу в качестве параметра передается символьная строка s, 
            //e-mail возвращается в той же строке s: public void SearchMail(ref string s).

            string users = "Кучма Андрей Витальевич & Kuchma@mail.ru\n" +
                           "Мизинцев Павел Николаевич & Pasha@mail.ru\n" +
                           "Иванов Иван Иванович & vano@mail.ru\n" +
                           "Клептунов Андрей Андреевич & klepaka@yandex.ru\n" +
                           "Синицкая-Фемиди Зося Викторовна & SinFem@yandex.ru\n" +
                           "Петриков Валентин & PV@mail.ru\n" +
                           "Мухатдинов Хассан Оглы & Muhatdinov@mail.ru";

            Console.WriteLine(users);
            Console.WriteLine();
            RipEmailsFromFile(ref users);
           
            Console.WriteLine(users);


        }
        static string StringReverse(string anyString)
        {
            Stack<char> stack = new();
            string result = "";

            anyString.ToCharArray();
            foreach (char c in anyString)
            {
                stack.Push(c);
            }
            for (int i = stack.Count; i > 0; i--)
            {
                result += stack.Pop();
            }
            return result;
        }
        static void RipEmailsFromFile(ref string file)
        {
            string cleanedString = "";

            string[] spearator = { "&" + 1, "\n" };
            string[] result = file.Split(spearator, file.Length, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in result)
            {
                if (item.Contains(".ru"))
                {
                    int start = item.IndexOf('&');
                    int end = item.IndexOf(".ru");
                    cleanedString += item.Substring(start + 2, end - start + 1) + Environment.NewLine;
                }
                file = cleanedString;
            }

            


        }
    }
}
