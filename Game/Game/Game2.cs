using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game2 : Knuckle
    {
        public void ArrOfKnuckle()
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
            RandomGen();
        }
        public void RandomGen()
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
        public int CheckInBox()
        {
            int x = 0;
            int masMAX = 0;
            x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(1); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {
                    if (ArrOfKnuckles[i, j] > masMAX)
                    {
                        masMAX = ArrOfKnuckles[i, j];
                    }
                    if (ArrOfKnuckles[i, j] == ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, ArrOfKnuckles.GetLength(1) - 1])
                    {
                        if (x == (ArrOfKnuckles.GetLength(0) * ArrOfKnuckles.GetLength(1)) - 2)
                        {
                            if (masMAX - ArrOfKnuckles[i, j] == masMAX)
                            {
                                x++;
                            }
                        }
                    }
                    else
                    {
                        if (ArrOfKnuckles[i, j] == ArrOfKnuckles[i, ArrOfKnuckles.GetLength(1) - 1])
                        {
                            if ((ArrOfKnuckles[i, ArrOfKnuckles.GetLength(1) - 1] != ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, ArrOfKnuckles.GetLength(1) - 1]))
                            {
                                if ((ArrOfKnuckles[i, ArrOfKnuckles.GetLength(1) - 1] - ArrOfKnuckles[i + 1, 0] == -1))
                                {
                                    x++;
                                }
                            }
                        }
                        else
                        {
                            if (ArrOfKnuckles[0, 0] != 0)
                            {
                                if (ArrOfKnuckles[i, j] - ArrOfKnuckles[i, j + 1] == -1)
                                {
                                    x++;
                                }
                            }
                        }
                    }
                }
            }
            if ((x != (ArrOfKnuckles.GetLength(0) * ArrOfKnuckles.GetLength(1)) - 1))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
