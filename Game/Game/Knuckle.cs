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
        public int this[int i, int j]
        {
            get 
            {
                return ArrOfKnuckles[i, j];
            }
            set 
            {
                ArrOfKnuckles[i, j] = value;
            }
        }

        public readonly int[,] ArrOfKnuckles;
        public readonly int Size;
        public Knuckle(int GetLenght)
        {
            this.ArrOfKnuckles = new int[GetLenght, GetLenght];
            Size = GetLenght;
            ArrOfKnuckle();
            RandomGen();
        }
        public Knuckle(List<int> mas)
        {
            ArrOfKnuckles = new int[(int)Math.Sqrt(mas.Count), (int)Math.Sqrt(mas.Count)];
            CheckNumber(mas);
            Size = (int)Math.Sqrt(mas.Count);
        }
        //--------------------------
        private void ArrFromString(List<int> Mas)
        {
            
            int x = 0;
            for (int i = 0; i < Math.Sqrt(Mas.Count); i++)
            {
                for (int j = 0; j < Math.Sqrt(Mas.Count); j++)
                {
                    this[i, j] = Mas[x];
                    x++;
                }
            }
        }
        private void CheckNumber(List<int> Mas)
        {
            int x = 0, Max = 0;
            for (int i = 0; i < Mas.Count; i++)
            {
                for (int j = 0; j < Mas.Count; j++)
                {
                    if (i == Mas[j])
                    {
                        x++;
                        if (Max < Mas[i])
                        {
                            Max = Mas[i];
                        }
                        break;
                    }
                }
            }
            if ((x == Mas.Count) && (Max == Mas.Count - 1))
            {
                ArrFromString(Mas);
            }
            else
            {
                
            }
        }
        private void CheckMas(List<int> Mas)
        {
            int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int x = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (Math.Sqrt(Mas.Count) == number[i])
                {
                    x++;
                    break;
                }
            }
            if (x > 0)
            {
                ArrFromString(Mas);
            }
            else
            {
                 
            }
        }
        //--------------------------
        private void ArrOfKnuckle()
        {
            int x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    this[i, j] = x;
                    x++;
                }
            }
        }
        public bool CheckTheKnuckle(int q)
        {
            int x = 0, y = 0, z = 0, c = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(1); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {
                    if (this[i, j] == q)
                    {
                        x = i;
                        y = j;
                    }
                    if (this[i, j] == 0)
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
        public void MovingTheKnuckles(int q)
        {
            int x = 0, y = 0, z = 0, c = 0, v = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(1); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {
                    if (this[i, j] == q)
                    {
                        x = i;
                        y = j;
                    }
                    if (this[i, j] == 0)
                    {
                        z = i;
                        c = j;
                    }
                }
            }
            v = this[x, y];
            this[x, y] = this[z, c];
            this[z, c] = v;
        }
        //==========================
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


                    x = this[i, j];
                    this[i, j] = this[z, c];
                    this[z, c] = x;


                }
            }
        }
    }
}