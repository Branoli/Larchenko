using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class Reader
    {
        public static List<int> mas;
        public static List<int> Readerr(string file)
        {
            string FileSeparator = File.ReadAllText(file, Encoding.GetEncoding(1251));
            string[] Mas = FileSeparator.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            CheckString(Mas);
            if (mas != null)
            {
                return mas;
            }
            else
            {
                return null;
            }
        }
        static void CheckString(string[] Mas)
        {             
            string[] RusAlph = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            string[] EuAlph = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int x = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < RusAlph.Length; j++)
                {
                    if (Mas[i].Contains(RusAlph[j]) == true)
                    {
                        x++;
                    }
                    if (Mas[i].Contains(RusAlph[j].ToLower()) == true)
                    {
                        x++;
                    }

                }
                for (int j = 0; j < EuAlph.Length; j++)
                {
                    if (Mas[i].Contains(EuAlph[j]) == true)
                    {
                        x++;
                    }
                    if (Mas[i].Contains(EuAlph[j].ToLower()) == true)
                    {
                        x++;
                    }
                }
            }
            if (x == 0)
            {
                Writer(Mas);
            }
        }
        static void Writer(string[] Mas)
        {
            mas = new List<int>();
            for (int i = 0; i < Mas.Length; i++)
            {
                mas.Add(Int32.Parse(Mas[i]));
            }
        }
    }
}
