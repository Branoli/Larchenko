using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Knuckle
    {
        public readonly int[,] ArrOfKnuckles;

        public Knuckle(int GetLenght)
        {
            this.ArrOfKnuckles = new int[GetLenght, GetLenght];
            this.ArrOfKnuckles = ArrOfKnuckle();
            RandomGen();
            Print.PrintMasOfKnuckle(ArrOfKnuckles);
            MovingTheKnuckles();
        }
        public Knuckle(string file)
        {
            string FileSeparator = File.ReadAllText(file, Encoding.GetEncoding(1251));
            string[] Mas = FileSeparator.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if ((CheckString(Mas) == true) && (CheckNumber(Mas) == true) && (CheckMas(Mas) == true))
            {
                this.ArrOfKnuckles = new int[(int)Math.Sqrt(Mas.Length), (int)Math.Sqrt(Mas.Length)];
                ArrFromString(Mas);
                Print.PrintMasOfKnuckle(ArrOfKnuckles);
                MovingTheKnuckles();
            }
            else
            {
                Print.PrintExseption(ArrOfKnuckles);
            }
        }

        private void ArrFromString(string[] Mas)
        {
            int x = 0;
            for (int i = 0; i < Math.Sqrt(Mas.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(Mas.Length); j++)
                {
                    ArrOfKnuckles[i, j] = Int32.Parse(Mas[x]);
                    x++;
                }
            }
            
        }
        private bool CheckNumber(string[] Mas)
        {
            int x = 0, Max = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas.Length; j++)
                {
                    if (i == Int32.Parse(Mas[j]))
                    {
                        x++;
                        if (Max < Int32.Parse(Mas[i]))
                        {
                            Max = Int32.Parse(Mas[i]);
                        }
                        break;
                    }
                }
            }
            if ((x == Mas.Length) && (Max == Mas.Length - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckString(string[] Mas)
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
            if (x > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckMas(string[] Mas)
        {
            int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int x = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (Math.Sqrt(Mas.Length) == number[i])
                {
                    x++;
                    break;
                }
            }
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int[,] FileInKnuckle(string[] FileSeparator)
        {
            int x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    
                }
            }
            return ArrOfKnuckles;

        }
        private int[,] ArrOfKnuckle()
        {
            int x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    ArrOfKnuckles[i, j] = x;
                    x++;
                }
            }
            return ArrOfKnuckles;
        }
        public bool CheckTheKnuckle(int q)
        {
            int x = 0, y = 0, z = 0, c = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(1); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {
                    if (ArrOfKnuckles[i,j] == q)
                    {
                        x = i;
                        y = j;
                    }
                    if (ArrOfKnuckles[i,j] == 0)
                    {
                        z = i;
                        c = j;
                    }
                }
            }
            if (Math.Sqrt(Math.Pow(z - x, 2) + Math.Pow(c - y, 2)) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void MovingTheKnuckles()
        {
            int q = 0;
            do
            {
                Print.PrintQ();
                q = Convert.ToInt32(Console.ReadLine());
            } while (CheckTheKnuckle(q) == false);


            int x = 0, y = 0, z = 0, c = 0, v = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(1); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {
                    if (ArrOfKnuckles[i, j] == q)
                    {
                        x = i;
                        y = j;
                    }
                    if (ArrOfKnuckles[i, j] == 0)
                    {
                        z = i;
                        c = j;
                    }
                }
            }
            v = ArrOfKnuckles[x, y];
            ArrOfKnuckles[x, y] = ArrOfKnuckles[z, c];
            ArrOfKnuckles[z, c] = v;
            Print.PrintMasOfKnuckle(ArrOfKnuckles);
            MovingTheKnuckles();
        }
        private void RandomGen()
        {
            Random gen = new Random();
            int x = 0, z = 0, c = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {

                    z = gen.Next(0, ArrOfKnuckles.GetLength(0));
                    c = gen.Next(0, ArrOfKnuckles.GetLength(1));


                    x = ArrOfKnuckles[i, j];
                    ArrOfKnuckles[i, j] = ArrOfKnuckles[z, c];
                    ArrOfKnuckles[z, c] = x;


                }
            }
        }
    }
}